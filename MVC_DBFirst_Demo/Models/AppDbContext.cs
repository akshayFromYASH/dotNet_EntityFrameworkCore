using Microsoft.EntityFrameworkCore;
using System;

namespace MVC_DBFirst_Demo.Models
{
    public class AppDbContext:DbContext{

        // We dont right anything in constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories {get;set;}

        public DbSet<Product> Products {get;set;}
    }
}