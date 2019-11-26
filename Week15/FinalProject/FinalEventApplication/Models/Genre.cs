using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalEventApplication.Models
{
    public class Venue
    {
        public virtual int VenueId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }        
    }
}