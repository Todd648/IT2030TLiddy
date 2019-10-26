using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models 
{
    public class Student : IValidatableObject    
    {
        public virtual string StudentID { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string FirstName { get; set; }
        public virtual string Address1 { get; set; }
        public virtual string Address2 { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string Zip { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
                if (Address2 == Address1)
                {
                yield return (new ValidationResult("Address2 cannot be the same as Address on"));
                }
                if (State.Length != 2)
                {
                yield return (new ValidationResult("Enter a 2 character state code"));
                }
                if (Zip.Length != 5)
                {
                yield return (new ValidationResult("Enter a 5 digit zipcode"));
                }
            //throw new NotImplementedException();
        }
    }
}