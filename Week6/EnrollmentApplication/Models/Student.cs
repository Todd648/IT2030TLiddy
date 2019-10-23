using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.ComponentModel.DataAnnotations;
>>>>>>> 284b57a00fe9ef6bf70f90b4ced01f9244f16b48
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
<<<<<<< HEAD
    public class Student    
    {
        public virtual string StudentID { get; set; }
        public virtual string LastName { get; set; }
=======
    public class Student
    {
        public virtual string StudentID { get; set; }
        [Required(ErrorMessage = "You can't leave this blank")]
        [StringLength(50)]
        public virtual string LastName { get; set; }
        [Required(ErrorMessage = "You can't leave this blank")]
        [StringLength(50)]
>>>>>>> 284b57a00fe9ef6bf70f90b4ced01f9244f16b48
        public virtual string FirstName { get; set; }
    }
}