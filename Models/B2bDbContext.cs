using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace b2b.Models
{
    public class B2bDbContext:DbContext
    {
        public B2bDbContext(DbContextOptions<B2bDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Order> Orders { get; set; }    
        public DbSet<User> Users { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
    }
}
