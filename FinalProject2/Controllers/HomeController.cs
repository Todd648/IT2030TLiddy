using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject2.Models;

namespace FinalProject2.Controllers
{
    public class HomeController : Controller
    {
        MVCEventDB db = new MVCEventDB();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult CitySearch(string q)
        {
            var results = GetCities(q);
            return PartialView(results);
        }
        private List<Event> GetCities(string searchString)
        {
            return db.Events
                .Where(a => a.VenueCity.Contains(searchString))
                .ToList();
        }
        public ActionResult StateSearch(string q)
        {
            var results = GetStates(q);
            return PartialView(results);
        }
        private List<Event> GetStates(string searchString)
        {
            return db.Events
                .Where(a => a.VenueState.Contains(searchString))
                .ToList();
        }
        public ActionResult TypeSearch(string q)
        {
            var results = GetTypes(q);
            return PartialView(results);
        }
        private List<Event> GetTypes(string searchString)
        {
            return db.Events
                .Where(a => a.Type.Name.Equals(searchString))
                .ToList();
        }

        public ActionResult EventSearch(string q)
        {
            var results = GetEvents(q);
            return PartialView(results);
        }
        private List<Event> GetEvents(string searchString)
        {
            return db.Events
                .Where(a => a.EventName.Contains(searchString))
                .ToList();
        }

        public ActionResult LastMinuteDeals()
        {
            var LastMinuteDeals = getDailyDeal();
            return PartialView("LastMinuteDeals", LastMinuteDeals);
        }
        private List<Event> getDailyDeal()
        {
            return db.Events.Where(a => a.StartDate < DateTime.Today.AddDays(2)).ToList();
        }



    }
}