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
    public class Course
    {
        public virtual string CourseID { get; set; }
<<<<<<< HEAD
        public virtual string CourseTitle { get; set; }
        public virtual string CourseDescription { get; set; }
=======
        [Required(ErrorMessage = "You can't leave this blank")]
        [StringLength(150)]
        public virtual string CourseTitle { get; set; }
        public virtual string CourseDescription { get; set; }
        [Required(ErrorMessage ="Enter a number from 1 to 4")]
        [Range (1,4)]
>>>>>>> 284b57a00fe9ef6bf70f90b4ced01f9244f16b48
        public virtual int CourseCredits { get; set; }
    }
}