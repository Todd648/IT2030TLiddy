using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace FinalProject.Models
{
    public class Cart
    {
        [Key] public int RecordID { get; set; }
        public string CartID { get; set; }
        public int EventID { get; set; }

        public virtual Event EventSelected { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Count { get; internal set; }
    }
}