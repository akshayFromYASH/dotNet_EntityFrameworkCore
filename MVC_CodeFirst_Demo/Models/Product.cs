using System.ComponentModel.DataAnnotations;

namespace MVC_CodeFirst_Demo.Models{
    public class Product{
       
        [Key]
        public int ProdId { get; set; }

        [Required(ErrorMessage="Enter Product Name"),]
        public string ProdName { get; set; }

        public  decimal Price { get; set; }

        public Category category { get; set; }
    
        public DateTime Mfd { get; set; }

        public DateTime Exd { get; set; }

    }
}