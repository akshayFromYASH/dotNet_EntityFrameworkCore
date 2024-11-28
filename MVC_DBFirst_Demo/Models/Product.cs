using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System;
namespace MVC_DBFirst_Demo.Models{
    public class Product{
        [Key]
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public decimal Price { get; set; }
        public int CatId { get; set; }
        public DateTime Mfd { get; set; }
        public DateTime Exd { get; set; }
    }
}