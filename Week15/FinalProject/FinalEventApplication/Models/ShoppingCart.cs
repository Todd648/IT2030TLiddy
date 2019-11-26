using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalEventApplication.Models
{
    public class ShoppingCart
    {
        public string ShoppingCartID;
        
        private FinalEventApplicationDB db = new FinalEventApplicationDB();

        public static ShoppingCart GetCart(HttpContextBase context)
        {
            ShoppingCart cart = new ShoppingCart();
            cart.ShoppingCartID = cart.GetCartID(context);
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
        public List<Cart> GetCartItems()
        {
            return db.Carts.Where(c => c.CartID == this.ShoppingCartID).ToList();
        }

        public decimal GetCartTotal()
        {
            decimal? total = (from cartItem in db.Carts
                        where cartItem.CartID == this.ShoppingCartID
                        select cartItem.EventSelected.Price * (int?)cartItem.Count).Sum();
            return total ?? decimal.Zero;
        }
        public void AddToCart(int EventID)
        {
            Cart cartItem = db.Carts.SingleOrDefault(c =>c.CartID == this.ShoppingCartID && c.EventID == EventID);
            if(cartItem == null)
            {
                cartItem = new Cart()
                {
                    CartID = this.ShoppingCartID,
                    EventID = EventID,
                    Count = 1,
                    DateCreated = DateTime.Now
                };
                db.Carts.Add(cartItem);
            }
            else
            {
                cartItem.Count++;
            }
            db.SaveChanges();
        }
        public int RemoveFromCart(int recordID)
        {
            Cart cartItem = db.Carts.SingleOrDefault(c => c.CartID == this.ShoppingCartID && c.RecordID == recordID);
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
                db.Carts.Remove(cartItem);
                newCount = 0;
            }
            db.SaveChanges();
            return newCount;
        }
    }
}