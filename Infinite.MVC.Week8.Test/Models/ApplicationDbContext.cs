using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Infinite.MVC.Week8.Test.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("MyCon")
        { 

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; } 
        //public DbSet<PackSize> PackSize { get; set; }
    }
}