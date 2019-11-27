using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class MVCEventDB : DbContext
    {
        public MVCEventDB() : base("name=MVCEventDB")
        {

        }
        public System.Data.Entity.DbSet<FinalProject.Models.Organizer> Organizers { get; set; }
        public System.Data.Entity.DbSet<FinalProject.Models.Venue> Venues { get; set; }
        public System.Data.Entity.DbSet<FinalProject.Models.Event> Events { get; set; }

    }
}