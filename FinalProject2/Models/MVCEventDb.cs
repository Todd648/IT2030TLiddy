using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Google;
using Owin;


namespace FinalProject2.Models
{
    public class MVCEventDB : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public MVCEventDB() : base("name=MVCEventDB")
        {
        }

        public System.Data.Entity.DbSet<FinalProject2.Models.Event> Events { get; set; }
        public System.Data.Entity.DbSet<FinalProject2.Models.Order> Orders { get; set; }

        public System.Data.Entity.DbSet<FinalProject2.Models.EventType> EventTypes { get; set; }
    }
}
