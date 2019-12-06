using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using FinalProject.Models;

namespace FinalProject.Models
{
    public class Order
    {
        [Key]
        public virtual int OrderID { get; set; }
        public virtual int TicketCount { get; set; }
        public virtual int EventID { get; set; }
    }
}