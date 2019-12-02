using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using FinalProject.Models;

namespace FinalProject.Models
{
    public class ShoppingCart
    {
        public string ShoppingCartID;

        private MVCEventDB db = new MVCEventDB();

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
            if (context.Session[CartSessionID] == null)
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

        public int GetCartTotal()
        {
            return 0;
            //int total = from cartItem in db.Carts where cartItem.CartID == ShoppingCartID select cartItem.Count;
            //int total = from cartItem in db.Carts
            //            where cartItem.CartID == ShoppingCartID
            //            select cartItem.EventSelected;
            //return total ?? int.Zero;
        }
        public void AddToCart(int eventID)
        {
            Cart cartItem = db.Carts.SingleOrDefault(c => c.CartID == this.ShoppingCartID && c.EventID == eventID);
            if (cartItem == null)
            {
                cartItem = new Cart()
                {
                    CartID = this.ShoppingCartID,
                    EventID = eventID,
                    Count = 1,
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
            if (cartItem.Count > 1)
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