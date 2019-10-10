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
    public class Enrollment
    {
        public virtual string EnrollmentID { get; set; }
        public virtual string StudentID { get; set; }
        public virtual string CourseID { get; set; }
<<<<<<< HEAD
=======
        [Required(ErrorMessage = "Those aren't grades")]
        [RegularExpression(@"[A-Fa-f]")]
>>>>>>> 284b57a00fe9ef6bf70f90b4ced01f9244f16b48
        public virtual char Grade { get; set; }
        public virtual object Student { get; set; }
        public virtual object Course { get; set; }
        public virtual Boolean IsActive { get; set; }
<<<<<<< HEAD
        public virtual string AssignedCampus { get; set; }
=======
        [Required]
        public virtual string AssignedCampus { get; set; }
        [Required]
        [Range(2018, 2147483647)]
>>>>>>> 284b57a00fe9ef6bf70f90b4ced01f9244f16b48
        public virtual string EnrollmentSemester { get; set; }
        public virtual int EnrollmentYear { get; set; }

    }
}