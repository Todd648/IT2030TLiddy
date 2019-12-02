using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class ShoppingCartController : Controller
    {
        MVCEventDB db = new MVCEventDB();
        // GET: ShoppingCart
        public ActionResult Index()
        {
            ShoppingCart cart = ShoppingCart.GetCart(this.HttpContext);
            ShoppingCartViewModel vm = new ShoppingCartViewModel()
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetCartTotal()
            };

            return View(vm);
        }
        public ActionResult AddToCart(int id)
        {
            ShoppingCart cart = ShoppingCart.GetCart(this.HttpContext);
            cart.AddToCart(id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            ShoppingCart cart = ShoppingCart.GetCart(this.HttpContext);
            Event eventID  = db.Carts.SingleOrDefault(c => c.RecordID == id).EventSelected;
            int newItemCount = cart.RemoveFromCart(id);
            // cart.RemoveFromCart(id);
            ShoppingCartRemoveViewModel vm = new ShoppingCartRemoveViewModel()
            {
                DeleteID = id,
                CartTotal = cart.GetCartTotal(),
                ItemCount = newItemCount,
                Message = "Your item has been removed from the cart"
            };
            return Json(vm);
        }
    }
}