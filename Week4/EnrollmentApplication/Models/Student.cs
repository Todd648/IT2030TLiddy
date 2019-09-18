using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnrollmentApplication.Models
{
    public class Student
    {
        public virtual string StudentID { get; set; }
        public virtual string LastName { get; set; }
        public virtual string FirstName { get; set; }
    }
}
