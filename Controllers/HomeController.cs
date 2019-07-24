using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using b2b.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using b2b.ViewModels;
using b2b.Controllersx;

namespace b2b.Controllers
{
    public class HomeController : Controller
    {
        B2bDbContext context;
       
        public static OrderCargo order_product = new OrderCargo();
        public HomeController(B2bDbContext c)
        {
            context = c;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult Products()
        {

            return View(context.Products);
        }
        [HttpPost]
        public IActionResult Products(int pid,int count)
        {
            int pcount = context.Products.Count(i => i.ProductId == pid);
            //Pid de seçilen ürünün pid si,countta sipariş adeti var.
            Product product = context.Products.FirstOrDefault(i => i.ProductId == pid);
            if (product.ProductCount < count)
            {
                //Stok adeti ve sipariş adetini kontrol ediyorum.Eğer yeterli stok adeti yoksa hata mesajı döndürüyorum.
                ViewBag.Message = "Not Enough Product Count";
                return View("Products",context.Products);
            }
            product.ProductCount -= count;//Sipariş verdiğim adette ürünü,ürün stok adetinden düşmeliyim.
            //Aşağıda pid ye göre ürünü order_product içine alıp,fiyatı adet*birim fiyat üstünden değiştirdim.
            //Artık order_product nesnesinde sipariş bilgilerine yönelik product bilgisi var.
            order_product.Product = context.Products.FirstOrDefault(i => i.ProductId == pid);
            order_product.Product.ProductCount = count;
            order_product.Product.ProductPrice = (order_product.Product.ProductPrice * count);
            return View("ConfirmOrder",order_product);
        }


        public IActionResult Orders()
        {
            return View(context.Orders);
        }
        [HttpPost]
        public IActionResult Orders(int oid)
        {
            //Sipariş tamamlanırsa cargo ve orders tablosundan ilgili oid ye sahip verileri silmeliyim.
            Order order = context.Orders.FirstOrDefault(i => i.OrderId == oid);
            Cargo cargo = context.Cargos.First(i => i.OrderId == oid);
            context.Orders.Remove(order);
            context.Cargos.Remove(cargo);
            context.SaveChanges();
            return View(context.Orders);
        }
        public IActionResult Partner()
        {
            return View(context.Companies);
        }
        public IActionResult Admin()
        {

            if (LoginController.role == true)
            {

                return RedirectToAction("Index", "User");
            }
            else
                return View();
        

        }
        public IActionResult AddUser()
        {
            UserCompany uc = new UserCompany();
            uc.companies = context.Companies.ToList();
            return View(uc);
        }
        [HttpPost]
        public IActionResult AddUser(User user)
        {
            UserCompany uc = new UserCompany();
            uc.companies = context.Companies.ToList();
            user.UserRole = true;
            context.Users.Add(user);
            context.SaveChanges();
            return View(uc);
        }
        public IActionResult DeleteUser()
        {
            return View(context.Users);
        }
        [HttpPost]
        public IActionResult DeleteUser(int id)
        {
            //Silmek istediğim user idsi asp-route-id ile dönüyor.ilgili userı dönen id ye göre sildim.
           User user = context.Users.FirstOrDefault(i => i.UserId == id);
            context.Users.Remove(user);
            context.SaveChanges();
            return View(context.Users);
        }
        public IActionResult UpdateUser()
        {
            CompanyUsers cu = new CompanyUsers();
            cu.Users = context.Users.ToList();
            cu.Company = context.Companies.ToList();
            return View(cu);
        }
        [HttpPost]
        public IActionResult UpdateUser(int uid,string userName,string userPassword)
        {
            User user = context.Users.FirstOrDefault(i => i.UserId == uid);
            user.UserName = userName;
            user.password = userPassword;
            ////admin yapma
            //user.UserRole = false;
          
            context.SaveChanges();
            
            CompanyUsers cu = new CompanyUsers();
            cu.Users = context.Users.ToList();
            cu.Company = context.Companies.ToList();
            return View(cu);
        }
        //[HttpPost]
        //public IActionResult Decline(bool nuid)
        //{
        //    User user = context.Users.FirstOrDefault(i => i.UserRole == nuid);
        //    user.UserRole = true;
        //    context.SaveChanges();
        //    CompanyUsers cu = new CompanyUsers();
        //    cu.Users = context.Users.ToList();
        //    cu.Company = context.Companies.ToList();
        //    return View(cu);
        //}


            
            public IActionResult AddPartner()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPartner(Company company)
        {
            //Eklemek istenen şirket bilgileri Company içinde paketlenip döndü.Direk companyi ekliyorum.
            context.Companies.Add(company);
            context.SaveChanges();
            return View();
        }
        public IActionResult DeletePartner()
        {
            return View(context.Companies);
        }
        [HttpPost]
        public IActionResult DeletePartner(int id)
        {
            //Silinecek şirketin id si parametre olarak geliyor.İlgili şirketi seçip siliyorum.
            Company company = context.Companies.FirstOrDefault(i => i.CompanyId == id);
            context.Remove(company);
            context.SaveChanges();
            return View(context.Companies);
        }
        public IActionResult UpdatePartner()
        {
            return View(context.Companies);
        }
        [HttpPost]
        public IActionResult UpdatePartner(string companyName,string companyTel,int id)
        {
            //id içinde bilgisi değişen şirket id si geliyor.yeni bilgilerde parametrelerde var.Önce id ile ilgili şirketi seçip daha sonra gelen parametreleri şirkete uyguladım.
            Company company = context.Companies.FirstOrDefault(i => i.CompanyId == id);
            company.CompanyName = companyName;
            company.CompanyTel = companyTel;
            context.SaveChanges();
            return View(context.Companies);
        }

        public IActionResult Confirmorder()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FinishOrder(string address)
        {
            //Seçilen ürünleri bilgileriyle beraber ordera ekledim.Sadece pid göndermedim çünkü fiyat,adet,..vs bilgisini kaybediyorum.
            //SAadece pid kullanıp join yapılabilirdi fakat yapı başlangıçta böylek kuruldu.
            Order order = new Order();
            Product product = context.Products.FirstOrDefault(i => i.ProductId == order_product.Product.ProductId);
            product.ProductCount -= order_product.Product.ProductCount;
            string date = DateTime.Now.ToShortTimeString();
            order.ProductCount = order_product.Product.ProductCount;
            order.OrderDate = DateTime.Now;
            order.ProductDesc = order_product.Product.ProductDesc;
            order.ProductName = order_product.Product.ProductName;
            order.ProductPrice = order_product.Product.ProductPrice;
            order.ProductId = order_product.Product.ProductId;
             context.Orders.Add(order);
            context.SaveChanges();
            //Order için Cargoya ekleme yapmam gerek.User tarafında kargo statei değiştiririlebilir durumda.
            //Cargo state i default olarak kargoya verilmedi olarak tutulacak.0->Verilmedi 1->Kargoda.
            //Orderla ilgili yaptığım eklemeyi cargodan önce save etmeliyim.Aksi takdirde foreign keyde sıkıntı çıkacaktır.
            //Son eklenen order id yi alarak cargo bilgisine foreign key olarak göndereceğim.
            int order_id = context.Orders.Max(i => i.OrderId);
            Cargo cargo = new Cargo();
            cargo.CargoAdress = address;
            cargo.CargoState = false;
            cargo.OrderId = order_id;
            context.Cargos.Add(cargo);
            context.SaveChanges();
            return View();
        }

    }
}
