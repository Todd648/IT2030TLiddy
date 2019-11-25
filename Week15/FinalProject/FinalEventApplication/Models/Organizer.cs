using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalEventApplication.Models
{
    public class Organizer
    {
        public virtual int OrganizerID { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual string PhoneNumber { get; set; }
    }
}