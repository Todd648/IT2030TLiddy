using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Venue
    {
        public virtual int VenueID { get; set; }
        public virtual string VenueName { get; set; }
        public virtual string VenueCity { get; set; }
        public virtual string VenueState { get; set; }
        public virtual Event Events { get; set; }
    }
}