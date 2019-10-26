using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using EnrollmentApplication.Models;


namespace EnrollmentApplication.Models
{
    public class Course
    {
        [Display(Name = "CourseID")]
        public virtual string CourseID { get; set; }
        [Display(Name = "Course Title")]
        [Required(ErrorMessage = "A Course Title is required")]
        [StringLength(150, ErrorMessage = "Course Title Cannot Exceed 150 Characters")]
        public virtual string CourseTitle { get; set; }
        [Display(Name = "Discription")]
        public virtual string CourseDescription { get; set; }
        [Display(Name = "Number of Credits")]
        [Required(ErrorMessage = "Course Credits must be between 1-4, and is required")]
        [Range(1, 4)]
        public virtual int CourseCredits { get; set; }
        public virtual string InstructorName { get; set; }
    }
}