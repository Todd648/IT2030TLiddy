using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalEventApplication.Models
{
    public class Event
    {
        public virtual int EventId { get; set; }
        public virtual int VenueId { get; set; }
        public virtual int OrganizerId { get; set; }
        public virtual string Title { get; set; }
        public virtual decimal Price { get; set; }
        public virtual Venue Venue { get; set; }
        public virtual Organizer Organizer { get; set; }
        public virtual string EventArtUrl {get; set;}
        public virtual string CountryOfOrigin { get; set; }
        public virtual bool InStock { get; set; }

    }
}