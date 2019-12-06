using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using FinalProject2.Models;

namespace FinalProject2.Models
{
    public class Event
    {
        [Key]
        public virtual int EventID { get; set; }
        public virtual int MaxTickets { get; set; }
        public virtual int AvailableTickets { get; set; }
        public virtual string EventName { get; set; }
        public virtual string Description { get; set; }
        public virtual EventType Type { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }
        public virtual string OrganizerEmail { get; set; }
        public virtual string OrganizerPhone { get; set; }
        public virtual string VenueName { get; set; }
        public virtual string VenueCity { get; set; }
        public virtual string VenueState { get; set; }


    }
}