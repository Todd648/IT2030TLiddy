using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Organizer
    {
        public virtual int OrganizerID {get; set;}
        public virtual string OrganizerEmail { get; set; }
        public virtual string OrganizerPhone { get; set; }
    }
}