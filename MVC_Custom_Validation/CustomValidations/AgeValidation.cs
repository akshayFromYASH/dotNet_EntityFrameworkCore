using MVC_Custom_Validation.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_Custom_Validation.CustomValidations{

    public class AgeValidation : ValidationAttribute{

        protected override ValidationResult IsValid(object value, ValidationContext validationContext){
            var student = (Student)validationContext.ObjectInstance;

            if(student.DOB == null){
                return new ValidationResult("Date of Birth is required");
            }

            var age = DateTime.Today.Year - student.DOB.Year;
            return (age>=18)
                        ? ValidationResult.Success 
                        : new ValidationResult("Age should be greater than 18!");
        }
    }   
}


// using System.ComponentModel.DataAnnotations;
// using MVC_Custom_Validation.Models;
// namespace MVC_Custom_Validation.CustomValidations
// {
 
   
// public class AgeValidation:ValidationAttribute
// {                                                                   //|-> on which onbject we are
//     protected override ValidationResult IsValid(object value,ValidationContext validationContext)
//     {
//         var student=(Student) validationContext.ObjectInstance;
 
//         if(student.DOB==null)
//             return new ValidationResult("date of birth is required");
//         var age=DateTime.Today.Year - student.DOB.Year;
 
//         return (age>=18)
//             ? ValidationResult.Success
//             :new ValidationResult("Student should be at least 18 yeasrs old");
//     }
// }
 
// }