using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
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
            var results = GetCity(q);
            return View(results);
        }

        private List<Event> GetCity(string searchString)
        {
            return db.Events
                .Where(a => a.VenueCity.Contains(searchString))
                .ToList();
        }
        public ActionResult StateSearch(string q)
        {
            var results = GetState(q);
            return View(results);
        }

        private List<Event> GetState(string searchString)
        {

            return db.Events
                .Where(a => a.VenueState.Contains(searchString))
                .ToList();
        }
        public ActionResult TypeSearch(string q)
        {
            var results = GetType(q);
            return View(results);
        }

        private List<Event> GetType(string searchString)
        {

            return db.Events
                .Where(a => a.Type.Name.Contains(searchString))
                .ToList();
        }
        public ActionResult EventSearch(string q)
        {
            var results = GetEvents(q);
            return View(results);
        }

        private List<Event> GetEvents(string searchString)
        {

            return db.Events
                .Where(a => a.EventName.Contains(searchString))
                .ToList();
        }



        public ActionResult LastMinuteDeals()
        {
            return View(db.Events.Where(a => a.StartDate >= DateTime.Today.AddDays(2)));
        }
    }
}