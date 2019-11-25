using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalEventApplication.Models
{
    public class SeedData
    { 
        public virtual Venue Venues { get; set; }
        public virtual Organizer Organizers { get; set; }
        public virtual Event Events { get; set; }
    }
}