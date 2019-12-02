using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using FinalProject.Models;

namespace FinalProject.Models
{
    public class Event
    {
        [Required]
        public virtual int EventID { get; set; }
        public virtual int MaxTickets { get; set; }
        public virtual int AvailableTickets { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual string EventType { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }
        public virtual Organizer Organizer { get; set; }

    }
}