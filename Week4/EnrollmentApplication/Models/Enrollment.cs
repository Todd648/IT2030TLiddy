using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnrollmentApplication.Models
{
    public class Enrollment
    {
        public virtual string EnrollmentID { get; set; }
        public virtual string StudentID { get; set; }
        public virtual string CourseID { get; set; }
        public virtual string Grade { get; set; }
    }
}
