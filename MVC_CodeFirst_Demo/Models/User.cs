using System.ComponentModel.DataAnnotations;

namespace MVC_CodeFirst_Demo.Models{
    public class User{

        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage="Name Required")]
        public string UserName { get; set; }

        [Required(ErrorMessage="Password Required")]
        public string? Password { get; set; }

        [Compare("Password",ErrorMessage="Password Doesnt Match")]
        public string? ConfirmPassword {get;set;}

    }
}