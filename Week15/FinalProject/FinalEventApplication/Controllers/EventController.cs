using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalEventApplication.Models;

namespace FinalEventApplication.Controllers
{
    public class EventController : Controller
    {
        private FinalEventApplicationDB db = new FinalEventApplicationDB();

        // GET: Event
        public ActionResult Index()
        {
            var Events = db.Events.Include(a => a.OrganizerId).Include(a => a.VenueId);
            return View(Events.ToList());
        }

        // GET: Event/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event Event = db.Events.Find(id);
            if (Event == null)
            {
                return HttpNotFound();
            }
            return View(Event);
        }

        // GET: Event/Create
        public ActionResult Create()
        {
            ViewBag.OrganizerId = new SelectList(db.Organizers, "OrganizerId", "Name");
            ViewBag.VenueId = new SelectList(db.Venues, "VenueId", "Name");
            return View();
        }

        // POST: Event/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EventId,VenueId,OrganizerId,Title,Price,EventArtUrl,CountryOfOrigin,InStock")] Event Event)
        {
            if (ModelState.IsValid)
            {
                db.Events.Add(Event);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.OrganizerId = new SelectList(db.Organizers, "OrganizerId", "Name", Event.OrganizerId);
            ViewBag.VenueId = new SelectList(db.Venues, "VenueId", "Name", Event.VenueId);
            return View(Event);
        }

        // GET: Event/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event Event = db.Events.Find(id);
            if (Event == null)
            {
                return HttpNotFound();
            }
            ViewBag.OrganizerId = new SelectList(db.Organizers, "OrganizerId", "Name", Event.OrganizerId);
            ViewBag.VenueId = new SelectList(db.Venues, "VenueId", "Name", Event.VenueId);
            return View(Event);
        }

        // POST: Event/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EventId,VenueId,OrganizerId,Title,Price,EventArtUrl,CountryOfOrigin,InStock")] Event Event)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Event).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OrganizerId = new SelectList(db.Organizers, "OrganizerId", "Name", Event.OrganizerId);
            ViewBag.VenueId = new SelectList(db.Venues, "VenueId", "Name", Event.VenueId);
            return View(Event);
        }

        // GET: Event/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event Event = db.Events.Find(id);
            if (Event == null)
            {
                return HttpNotFound();
            }
            return View(Event);
        }

        // POST: Event/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Event Event = db.Events.Find(id);
            db.Events.Remove(Event);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
