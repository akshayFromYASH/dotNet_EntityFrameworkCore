using System.ComponentModel.DataAnnotations;

namespace MVC_CodeFirst_Demo.Models{
    public class Employee{

        [Key]
        public int EmpId { get; set; }

        [Required(ErrorMessage="Must Enter Employee Name")]
        public string EmpName { get; set; }

        public decimal Salary { get; set; }

        public Department department {get;set;}
    }
}