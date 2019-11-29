using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using FinalProject.Models;

namespace FinalProject.Models
{
    public class Venue
    {
        [Required]
        public virtual int VenueID { get; set; }
        public virtual string VenueName { get; set; }
        public virtual string VenueCity { get; set; }
        public virtual string VenueState { get; set; }
    }
}