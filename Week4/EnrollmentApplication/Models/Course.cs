using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnrollmentApplication.Models
{
    public class Course
    {
        public virtual string CourseID { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual string Credits { get; set; }
    }
}
