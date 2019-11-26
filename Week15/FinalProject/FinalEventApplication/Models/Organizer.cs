using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalEventApplication.Models
{
    public class Organizer
    {
        public virtual int OrganizerId { get; set; }
        public virtual string Name { get; set; }
    }
}