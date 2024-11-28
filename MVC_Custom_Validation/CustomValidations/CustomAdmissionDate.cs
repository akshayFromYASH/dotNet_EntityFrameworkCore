using System;
using System.ComponentModel.DataAnnotations;
 
namespace MVC_Custom_Validation.CustomValidations
{
    public class CustomAdmissionDate : ValidationAttribute{

        public override bool IsValid(object value)
        {
            // DateTime userenterdate = Convert.ToDateTime(value);
            if(value is DateTime userenterdate){
                return userenterdate >= DateTime.Now;
            }
            return false;
            
        }

    }
}