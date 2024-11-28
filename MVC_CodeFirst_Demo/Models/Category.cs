using System.ComponentModel.DataAnnotations;

namespace MVC_CodeFirst_Demo.Models{
    public class Category{

        [Key]
        public int CatId { get; set; }

        [Required(ErrorMessage="Must Enter Category Name")]
        public string CatName { get; set; }

        public ICollection<Product> products { get; set; }
    }
}