using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using FinalProject2.Models;

namespace FinalProject2.Models
{
    public class Order
    {
        [Key] public int OrderID { get; set; }
        public string CartID { get; set; }
        public int EventID { get; set; }
        public virtual Event EventSelected { get; set; }
        public int Count { get; set; }
    }
}