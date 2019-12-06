using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using FinalProject.Models;

namespace FinalProject.Models
{
    public class EventType
    {
        [Key]
        public virtual int TypeID { get; set; }
        public virtual string Name { get; set; }
    }
}