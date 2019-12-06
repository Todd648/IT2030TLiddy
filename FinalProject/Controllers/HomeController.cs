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
        private MVCEventDB db = new MVCEventDB();

        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult EventTypeSearch(string q)
        {
            var events = GetTypes(q);
            return PartialView(events);
        }
        private List<Event> GetTypes(string searchString)
        {
            return db.Events
                .Where(a => a.Type.Name.Contains(searchString))
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
                .Where(a => a.VenueCity.Contains(searchString))
                .ToList();
        }
        //Get: Deals
        public ActionResult DailyDeal(DateTime dateTime)
        {
            var DailyDeal = GetDailyDeal(dateTime);
            return PartialView("DailyDeal", DailyDeal);
        }
        private List<Event> GetDailyDeal(DateTime dateTime)
        {
            DateTime theFuture = DateTime.Today.AddDays(2);
            DateTime thePast = DateTime.Today.AddDays(-1);

            var dailydeal = db.Events
                    .Where(a => a.StartDate <= theFuture)
                    .Where(a => a.StartDate > thePast)
                    .ToList();
            return dailydeal;
        }

    }
}