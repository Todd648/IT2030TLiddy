using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject2.Models;

namespace FinalProject2.Models
{
    public class OrderCart
    {
        public string OrderCartID;
        
        private MVCEventDB db = new MVCEventDB();

        public static OrderCart GetCart(HttpContextBase context)
        {
            OrderCart cart = new OrderCart();
            cart.OrderCartID = cart.GetCartID(context);
            return cart;
        }
        private string GetCartID(HttpContextBase context)
        {
            const string CartSessionID = "CartID";
            string cartID;
            if(context.Session[CartSessionID]==null)
            {
                cartID = Guid.NewGuid().ToString();
                context.Session[CartSessionID] = cartID;
            }
            else
            {
               cartID = context.Session[CartSessionID].ToString();
            }
            return cartID;
        }
        public List<Order> GetCartItems()
        {
            return db.Orders.Where(c => c.CartID == this.OrderCartID).ToList();
        }
        
        public void AddOrder(int eventID)
        {
            Order cartItem = db.Orders.SingleOrDefault(c =>c.CartID == this.OrderCartID && c.EventID == eventID);
            if(cartItem == null)
            {
                cartItem = new Order()
                {
                    CartID = this.OrderCartID,
                    EventID = eventID,
                    Count = 1,
                };
                db.Orders.Add(cartItem);
            }
            else
            {
                cartItem.Count++;
            }
            db.SaveChanges();
        }
        public int RemoveOrder(int OrderID)
        {
            Order cartItem = db.Orders.SingleOrDefault(c => c.CartID == this.OrderCartID && c.OrderID == OrderID);
            if (cartItem == null)
            {
                throw new NullReferenceException();
            }

            int newCount;
            if(cartItem.Count > 1)
            {
                cartItem.Count--;
                newCount = cartItem.Count;
            }
            else
            {
                db.Orders.Remove(cartItem);
                newCount = 0;
            }
            db.SaveChanges();
            return newCount;
        }
    }
}