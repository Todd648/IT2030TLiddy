using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalProject2.Models;

namespace FinalProject2.Controllers
{
    public class OrdersController : Controller
    {

        MVCEventDB db = new MVCEventDB();

        // GET: Orders
        public ActionResult Index()
        {
            OrderCart cart = OrderCart.GetCart(this.HttpContext);
            OrderCartViewModel vm = new OrderCartViewModel()
            {
                CartItems = cart.GetCartItems(),
            };

            return View(vm);
        }
        [Authorize]
        public ActionResult AddOrder(int id)
        {
            OrderCart cart = OrderCart.GetCart(this.HttpContext);
            cart.AddOrder(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult RemoveOrder(int id)
        {
            OrderCart cart = OrderCart.GetCart(this.HttpContext);
            Event @event = db.Orders.SingleOrDefault(e => e.OrderID == id).EventSelected;
            int newItemCount = cart.RemoveOrder(id);
            // cart.RemoveFromCart(id);
            OrderCartRemoveViewModel vm = new OrderCartRemoveViewModel()
            {
                DeleteID = id,
                ItemCount = newItemCount,
                Message = @event + " has been removed from the cart"
            };
            return Json(vm);
        }

        public ActionResult Register()
        {
            return View("~/Views/Account/Login.cshtml");
        }

        public ActionResult OrderSummary()
        {
            return View("~/Views/Orders/OrderSummary.cshtml");
        }
    }
}
