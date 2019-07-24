using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using b2b.Models;
using b2b.Controllers;
using b2b.ViewModels;
namespace b2b.Controllersx
{
    public class UserController : Controller
    {

        B2bDbContext context;
        public static int cid;
        LoginController LoginController;

        public UserController(B2bDbContext c)
        {
            context = c;

        }

        public IActionResult Index()
        {
            UserCompany uc = new UserCompany();
            cid = LoginController.active_user.CompanyId;
            uc.user = LoginController.active_user;
            uc.companies = context.Companies.Where(i => i.CompanyId == cid).ToList();
            return View(uc);
        }
        [HttpPost]
        public IActionResult Index(int uid,string userName,string userPassword)
        {
            cid = LoginController.active_user.CompanyId;
            UserCompany uc = new UserCompany();
            uc.companies = context.Companies.Where(i => i.CompanyId == cid).ToList();
            LoginController.active_user.UserName = userName;
            LoginController.active_user.password = userPassword;
            uc.user = LoginController.active_user;
            
            context.SaveChanges();
            return View(uc);
        }
      
        public IActionResult Company()
        {
            cid = LoginController.active_user.CompanyId;
            return View(context.Companies.Where(i => i.CompanyId == cid));
        }

        public IActionResult Products()//giriş yapılan şirketin ürünlerini gösteriyor
        {
            cid = LoginController.active_user.CompanyId;
            return View(context.Products.Where(i => i.CompanyId == cid));
        }
        public IActionResult AddDeleteUpdate()//ürün ekleme,silme ve update işlemlerşnden birinin seçileceği sayfa
        {

            return View();
        }
        public IActionResult _Add()//ürün ekleme sayfası
        {

            return View();
        }
        [HttpPost]
        public IActionResult _Add(Product product)
        {
            product.CompanyId = LoginController.active_user.CompanyId;
            context.Products.Add(product);
            context.SaveChanges();
            return View();
        }



        public IActionResult _Delete()//ürün silme sayfası
        {

            return View(context.Products);
        }

        [HttpPost]
        public IActionResult _Delete(int cid)
        {

            Product s = context.Products.FirstOrDefault(o => o.ProductId == cid);
            context.Products.Remove(s);
            context.SaveChanges();
            return View(context.Products);
        }
        public IActionResult UpdateProduct()//güncelleme sayfası
        {
            return View(context.Products);
        }
        [HttpPost]
        public IActionResult UpdateProduct(int pid, string pname, int pcount, int price,string pdesc)
        {
            Product product = context.Products.FirstOrDefault(f => f.ProductId == pid);
            product.ProductName = pname;
            product.ProductPrice = price;
            product.ProductCount = pcount;
            product.ProductDesc = pdesc;
            context.SaveChanges();
            return View(context.Products);
        }

        public IActionResult Orders()//sipariş edilen ürünler
        {


                var order = from m in context.Orders
                            join mc in context.Products
                            on m.ProductId equals mc.ProductId
                            join c in context.Cargos
                            on m.OrderId equals c.OrderId
                            where c.CargoState == false
                            select m;
               

            
            return View(order.ToList());
        }
        [HttpPost]
        public IActionResult Orders(int sid, bool Kargo)//kargoya verildikten sonra ürünün cargo tablosunda cargostate değişiyor
        {
            var order1 = from m in context.Products
                         join mc in context.Orders
                         on m.ProductId equals mc.ProductId
                         select m;
            if (Kargo == true)
            {
                Cargo n = new Cargo();
                Order o = new Order();
                o = context.Orders.FirstOrDefault(i => i.ProductId == sid);
                n = context.Cargos.FirstOrDefault(f => f.OrderId == o.OrderId);
                n.CargoState = Kargo;
                context.SaveChanges();

                var order = from m in context.Orders
                            join mc in context.Products
                            on m.ProductId equals mc.ProductId
                            join c in context.Cargos
                            on m.OrderId equals c.OrderId
                            where c.CargoState == false
                            select m;
                return View(order.ToList());
                
            }
            return View(order1.ToList());
        }
        public IActionResult Cargo()//kargolanan ürünler
        {

            var order = from m in context.Products
                        join mc in context.Orders
                        on m.ProductId equals mc.ProductId
                        join c in context.Cargos
                        on mc.OrderId equals c.OrderId
                        where c.CargoState == true
                        select m;
            return View(order.ToList());
        }

    }
}