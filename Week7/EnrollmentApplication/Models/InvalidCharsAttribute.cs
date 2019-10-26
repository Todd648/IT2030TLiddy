using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class InvalidCharsAttribute : ValidationAttribute
    {
        readonly string invalidchars;
        public InvalidCharsAttribute(string invalidchars)
        {
            this.invalidchars = invalidchars;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value !=null)
            {
                string s1 = value.ToString();
                int res1 = invalidchars.IndexOf(s1); 
                
                if (res1 > 0)
                {
                    return new ValidationResult("Notes contains invalid characters!");
                }
            }
            return ValidationResult.Success;
            //return base.IsValid(value, validationContext);
        }
    }
}