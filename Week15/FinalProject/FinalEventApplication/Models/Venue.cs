using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalEventApplication.Models
{
    public class Venue
    {
        public virtual int VenueID { get; set; }
        public virtual string VenueName { get; set; }
        public virtual string VenueAddress { get; set; }
        public virtual Event VenueEvents { get; set; }
    }
}