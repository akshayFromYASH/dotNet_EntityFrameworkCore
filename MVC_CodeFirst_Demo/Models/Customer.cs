using System.ComponentModel.DataAnnotations;


namespace MVC_CodeFirst_Demo.Models
{
    public class Customer
    {
        [Key]
        public int CustId {get; set;}

        [Required(ErrorMessage = "FirstName is Required")]
        [StringLength(30,MinimumLength=2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is Required")]
        [StringLength(30,MinimumLength=2)]
        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        [EmailAddress(ErrorMessage="Use Email Pattern")]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        public string URL { get; set; }

        [Range(minimum:16,maximum:65,ErrorMessage="Age must be between 16 to 65")]
        public int Age { get; set; }

    }
}