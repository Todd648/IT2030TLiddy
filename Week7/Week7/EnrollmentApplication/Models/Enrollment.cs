﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace EnrollmentApplication.Models
{
    public class Enrollment
    {
        public virtual string EnrollmentID { get; set; }
        public virtual string StudentID { get; set; }
        public virtual string CourseID { get; set; }
        [Required]
        [RegularExpression(@"[A-Fa-f]")]
        public virtual char Grade { get; set; }
        public virtual object Student { get; set; }
        public virtual object Course { get; set; }
        public virtual Boolean IsActive { get; set; }
        [Required]
        public virtual string AssignedCampus { get; set; }
        [Required]
        public virtual string EnrollmentSemester { get; set; }
        [Required]
        [Range(2018, 2147483647)]
        public virtual int EnrollmentYear { get; set; }

    }
}