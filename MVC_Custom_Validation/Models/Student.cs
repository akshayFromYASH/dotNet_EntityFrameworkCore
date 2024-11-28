using System;
using System.ComponentModel.DataAnnotations;
using MVC_Custom_Validation.CustomValidations;

namespace MVC_Custom_Validation.Models
{
    public class Student
 
    {
        [Key]
        public int Id { get; set; }
 
        [Required(ErrorMessage="Please Enter name ")]
        public string Name { get; set; }
 
        [Required(ErrorMessage="Please choose admission date ")]
        [Display(Name="Admission Date")]
 
        [DataType(DataType.DateTime)]
        [CustomAdmissionDate(ErrorMessage="Admission Date Should Not exceed Current Date")]
        public DateTime DOA { get; set; }
 
        [AgeValidation(ErrorMessage="Student age is less than 18")]
        public DateTime DOB { get; set; }

    }
}