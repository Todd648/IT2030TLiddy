﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class Student
    {
        public virtual string StudentID { get; set; }
        [Required(ErrorMessage = "You can't leave this blank")]
        [StringLength(50)]
        public virtual string LastName { get; set; }
        [Required(ErrorMessage = "You can't leave this blank")]
        [StringLength(50)]
        public virtual string FirstName { get; set; }
    }
}