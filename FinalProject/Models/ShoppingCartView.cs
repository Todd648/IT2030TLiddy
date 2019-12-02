using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems;
        public virtual int CartTotal { get; set; }
    }
}