using Microsoft.EntityFrameworkCore;
using MVC_CodeFirst_Demo.Models;

namespace MVC_CodeFirst_Demo.Controllers{

    public class AppDbContext:DbContext{

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){ }

        public DbSet<Customer> Customers {get;set;}
        public DbSet<Employee> Employees {get;set;}
        public DbSet<Department> Departments {get;set;}
        public DbSet<User> Users {get;set;}
    }
}