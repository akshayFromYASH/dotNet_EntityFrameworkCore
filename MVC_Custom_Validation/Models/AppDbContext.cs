using Microsoft.EntityFrameworkCore;
 
 
namespace  MVC_Custom_Validation.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){ }
 
 
          public DbSet<Student> students {get;set;}
    }
}
 