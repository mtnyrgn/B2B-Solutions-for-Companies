using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace b2b.Models
{
    public static class DbInitializer
    {
        public static void InitializeDb(IApplicationBuilder app)
        {

            B2bDbContext context = app.ApplicationServices.GetRequiredService<B2bDbContext>();
            //Migrationsları burda yarattığımız context üzerinden erişeceğiz!
            context.Database.Migrate();
            if (!context.Companies.Any())
            {
                var company = new Company() { CompanyName = "Temsa", CompanyTel = "46546" };
                context.Companies.AddRange(company);
             
            }
            if (!context.Users.Any())
            {
                var user = new User() { UserName = "admin", password = "root", UserRole = false ,CompanyId=1};
                //0->admin, 1->user
                context.Users.AddRange(
                    new User() { UserName = "admin", password = "root", UserRole = false, CompanyId = 1 },
                    new User() { UserName = "temsa", password = "root", UserRole = true, CompanyId = 1 }
                );
                context.SaveChanges();
            }
        
           

}
    }
}
