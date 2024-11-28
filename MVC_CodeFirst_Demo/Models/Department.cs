using System.ComponentModel.DataAnnotations;

namespace MVC_CodeFirst_Demo.Models{
    public class Department{

        [Key]
        public int DeptId { get; set; }

        [Required(ErrorMessage="Must Enter Department Name")]
        public string DeptName { get; set; }

        // one to many relation
        public ICollection<Employee> employees {get;set;}
    }
}