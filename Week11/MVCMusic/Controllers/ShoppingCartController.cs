using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStore.Models;

namespace MVCMusicStore.Controllers
{
    public class ShoppingCartController : Controller
    { MVCMusicStoreDB db = new MVCMusicStoreDB();
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
        [HttpPost] public ActionResult RemoveFromCart(int id)
        {
            ShoppingCart cart = ShoppingCart.GetCart(this.HttpContext);
            Album album = db.Carts.SingleOrDefault(c => c.RecordID == id).AlbumSelected;
            int newItemCount = cart.RemoveFromCart(id);
            // cart.RemoveFromCart(id);
            ShoppingCartRemoveViewModel vm = new ShoppingCartRemoveViewModel()
            {
                DeleteID = id,
                CartTotal = cart.GetCartTotal(),
                ItemCount = newItemCount,
                Message = album.Title + " has been removed from the cart"
            };
            return Json(vm);
        }
    }
}