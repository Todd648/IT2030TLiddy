using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalEventApplication.Models
{
    public class Cart
    {
        public virtual int RecordID { get; set; }
        public virtual int CartID { get; set; }
        public virtual Event Event { get; set; }
        public virtual int TicketCount { get; set; }
    }
}