using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using FinalProject2.Models;

namespace FinalProject2.Models
{
    public class EventType
    {
        [Key]
        public virtual int TypeID { get; set; }
        public virtual string Name { get; set; }
    }
}