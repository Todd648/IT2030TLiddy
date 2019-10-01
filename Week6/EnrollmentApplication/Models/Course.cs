using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class Course
    {
        public virtual string CourseID { get; set; }
        [Required(ErrorMessage = "You can't leave this blank")]
        [StringLength(150)]
        public virtual string CourseTitle { get; set; }
        public virtual string CourseDescription { get; set; }
        [Required(ErrorMessage ="Enter a number from 1 to 4")]
        [Range (1,4)]
        public virtual int CourseCredits { get; set; }
    }
}