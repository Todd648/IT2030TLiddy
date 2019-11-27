using FinalEventApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace FinalEventApplication.Controllers
{
    public class StoreController : Controller
    {
        FinalEventApplicationDB db = new FinalEventApplicationDB();

        // GET: Store
        public ActionResult Index(int id)
        {
            return View(GetEvents(id));
        }

        private List<Event> GetEvents(int id)
        {
            return db.Events
                .ToList();
        }

        // GET: Browse
        public ActionResult Browse()
        {
            
            return View(db.Venues.ToList());
        }

        // GET: Store
        public ActionResult Details(int id)
        {
            return View(GetDetails(id));
        }

        private List<Event> GetDetails(int id)
        {
            return db.Events
                .Where(a => a.EventId == (id))
                .ToList();
        }

        // GET: ShoppingCart
        public ActionResult ShoppingCart()
        {
            return View();
        }

        // GET: ShoppingCart/AddToCart
        public ActionResult AddToCart(int id)
        {
            return null;
        }
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
        public ActionResult OrganizerSearch(string q)
        {
            var Organizers = GetOrganizers(q);
            return PartialView(Organizers);
        }
        private List<Organizer>GetOrganizers(string searchString)
        {
            return db.Organizers
                .Where(a => a.EmailAddress.Contains(searchString))
                .ToList();
        }
    }
}