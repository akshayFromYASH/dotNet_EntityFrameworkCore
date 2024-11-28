using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System;

namespace MVC_DBFirst_Demo.Models{
    public class Category{
        [Key]
        public int CatId { get; set; }
        public string CatName { get; set; }
    }
}