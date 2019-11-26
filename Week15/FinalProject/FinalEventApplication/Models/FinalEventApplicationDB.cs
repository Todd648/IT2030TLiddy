﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalEventApplication.Models
{
    public class FinalEventApplicationDB : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public FinalEventApplicationDB() : base("name=FinalEventApplicationDB")
        {
        }

        public System.Data.Entity.DbSet<FinalEventApplication.Models.Event> Events { get; set; }

        public System.Data.Entity.DbSet<FinalEventApplication.Models.Organizer> Organizers { get; set; }

        public System.Data.Entity.DbSet<FinalEventApplication.Models.Venue> Venues { get; set; }

        public System.Data.Entity.DbSet<FinalEventApplication.Models.Cart> Carts { get; set; }
    }
}
