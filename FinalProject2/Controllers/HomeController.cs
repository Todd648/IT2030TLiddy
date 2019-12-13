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

        public ActionResult SearchIt(string q)
        {
            var artists = GetsSomething(q);
            return PartialView(artists);
        }
        private List<Event> GetsSomething(string searchString)
        {
            return db.Events
                .Where(a => a.EventName.Contains(searchString))
                .ToList();
        }






        public ActionResult CitySearch(string c)
        {
            var cities = GetCities(c);
            return PartialView(cities);
        }
        private List<Event> GetCities(string searchString)
        {
            return db.Events
                .Where(a => a.VenueCity.Contains(searchString))
                .ToList();
        }
        public ActionResult StateSearch(string s)
        {
            var states = GetStates(s);
            return PartialView(states);
        }
        private List<Event> GetStates(string searchString)
        {
            return db.Events
                .Where(a => a.VenueState.Contains(searchString))
                .ToList();
        }
        public ActionResult TypeSearch(string t)
        {
            var types = GetTypes(t);
            return PartialView(types);
        }
        private List<Event> GetTypes(string searchString)
        {
            return db.Events
                .Where(a => a.Type.Name.Equals(searchString))
                .ToList();
        }

        public ActionResult EventSearch(string e)
        {
            var events = GetEvents(e);
            return PartialView(events);
        }
        private List<Event> GetEvents(string searchString)
        {
            return db.Events
                .Where(a => a.EventName.Contains(searchString))
                .ToList();
        }

        public ActionResult LastMinuteDeals()
        {
            List<Event> LastMinuteDeals = GetLastMinuteDeals();
            return PartialView(LastMinuteDeals);
        }
        private List<Event> GetLastMinuteDeals()
        {
            var comingSoon = DateTime.Today.AddDays(3);
            var thePast = DateTime.Today.AddDays(-1);

            return db.Events.Where(a => a.StartDate > thePast && a.StartDate <= comingSoon).ToList();
        }



    }
}