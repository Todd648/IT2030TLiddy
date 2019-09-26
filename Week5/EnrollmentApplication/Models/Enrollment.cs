using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class Enrollment
    {
        public virtual string EnrollmentID { get; set; }
        public virtual string StudentID { get; set; }
        public virtual string CourseID { get; set; }
        public virtual char Grade { get; set; }
        public virtual object Student { get; set; }
        public virtual object Course { get; set; }
        public virtual Boolean IsActive { get; set; }
        public virtual string AssignedCampus { get; set; }
        public virtual string EnrollmentSemester { get; set; }
        public virtual int EnrollmentYear { get; set; }

    }
}