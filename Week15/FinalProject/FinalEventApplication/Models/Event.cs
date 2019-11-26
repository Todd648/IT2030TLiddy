using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalEventApplication.Models
{
    public class Event
    {
        public virtual int EventId { get; set; }
        public virtual int MaxTickets { get; set; }
        public virtual int AvailTickets { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual string EventType { get; set; }
        public virtual DateTime StartDate { get; set;}
        public virtual DateTime EndDate { get; set; }
        public virtual Venue VenueId { get; set; }
        public virtual Organizer OrganizerId { get; set; }
    }
}