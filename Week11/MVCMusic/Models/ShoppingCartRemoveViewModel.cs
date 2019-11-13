using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMusicStore.Models
{
    public class ShoppingCartRemoveViewModel
    {
        public int DeleteID;
        public decimal CartTotal;
        public int ItemCount;
        public string Message;

    }
}