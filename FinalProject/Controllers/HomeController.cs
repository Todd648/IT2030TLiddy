using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        MVCEventDB db = new MVCEventDB();

        //Get: Home
        public ActionResult Index(int id)
        {
            return View(GetEvents(id));
        }

        private List<Event> GetEvents(int id)
        {
            return db.Events
                .Where(a => a.EventID == (id))
                .ToList();
        }

        //Get: Browse
        public ActionResult Browse()
        {
            return View(db.Events.ToList());
        }

        //Get: Details
        public ActionResult Details(int id)
        {
            return View(GetDetails(id));
        }
        private List<Event> GetDetails(int id)
        {
            return db.Events
                .Where(e => e.EventID == (id))
                .ToList();
        }

        //Get: Deals
        public ActionResult DailyDeal()
        {
            var DailyDeal = getDailyDeal();
            return PartialView("DailyDeal", DailyDeal);
        }
        private Event getDailyDeal()
        {
            var dailydeal = db.Events
                .OrderBy(a => Guid.NewGuid()).First();
            return dailydeal;
        }

        //Get: ShoppingCart
        public ActionResult ShoppingCart()
        {
            return View();
        }
        public ActionResult AddToCart(int id)
        {
            return null;
        }

        //Get: EventsByType
        public ActionResult EventTypeSearch(string q)
        {
            var events = GetTypes(q);
            return PartialView(events);
        }
        private List<Event> GetTypes(string searchString)
        {
            return db.Events
                .Where(a => a.EventType.Contains(searchString))
                .ToList();
        }

        //Get: EventsByCity
        public ActionResult EventCitySearch(string q)
        {
            var events = GetCity(q);
            return PartialView(events);
        }
        private List<Event> GetCity(string searchString)
        {
            return db.Events
                .Where(a => a.Description.Contains(searchString))
                .ToList();
        }
    }
}