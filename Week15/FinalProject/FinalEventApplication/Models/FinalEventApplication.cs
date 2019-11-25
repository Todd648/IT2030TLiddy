using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FinalEventApplication.Models
{
    public class FinalEventApplication : DbContext
    {
       public FinalEventApplication() : base("name=FinalEventApplication")
            {
            }
        }
}