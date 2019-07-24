using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using b2b.Models;
using b2b.ViewModels;

namespace b2b.Controllers
{
    public class LoginController : Controller
    {
        B2bDbContext context;
        public static User active_user = new User();
        public UserCompany uc = new UserCompany(); 
        public LoginController(B2bDbContext c)
        {
            context = c;
        }
        private const string controller = "~/Views/Home/Index.cshtml";
       public static  bool role = true;


        public IActionResult Index() { 
            return View();
        }
        [HttpPost]
        public IActionResult Index(string username,string password)
        {
          
            foreach(var item in context.Users)
            {
                //admin role=0,user role=1
                if(item.UserName== username && item.password == password)
                {
                    role = item.UserRole;
                    active_user.UserId = item.UserId;
                    active_user.CompanyId = item.CompanyId;
                    active_user.UserName = item.UserName;
                    active_user.password = item.password;
                    uc.user = active_user;
                    uc.companies = context.Companies.Where(i => i.CompanyId == active_user.CompanyId).ToList();
                    if (!role)
                    {
                        return View("~/Views/Home/Index.cshtml");//Admin girişi yapıldı
                    }
                    else
                    {
                        return View("~/Views/User/Index.cshtml",uc);//User girişi yapıldı
                    }
                  
                }
            
            }
             return View();
        }
        public static bool Role1()
        {

            return role;
        }
    }
}