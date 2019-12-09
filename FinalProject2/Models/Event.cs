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
        [Required][StringLength(50)]
        public virtual string EventName { get; set; }
        [StringLength(150)]
        public virtual string Description { get; set; }
        public virtual EventType Type { get; set; }
        [Required]
        public virtual DateTime StartDate { get; set; }
        [Required]
        public virtual DateTime EndDate { get; set; }
        [Required]
        public virtual string OrganizerName { get; set; }
        [EmailAddress]
        public virtual string OrganizerEmail { get; set; }
        [Phone]
        public virtual string OrganizerPhone { get; set; }
        [Required][MaxLength(50)]
        public virtual string VenueName { get; set; }
        public virtual string VenueCity { get; set; }
        [StringLength(2)]
        public virtual string VenueState { get; set; }
        [Required][Range(1,320000)]
        public virtual int MaxTickets { get; set; }
        [Required][Range(1,320000)]
        public virtual int AvailableTickets { get; set; }

    }
}