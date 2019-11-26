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
    public class VenueController : Controller
    {
        private FinalEventApplicationDB db = new FinalEventApplicationDB();

        // GET: Venue
        public ActionResult Index()
        {
            return View(db.Venues.ToList());
        }

        // GET: Venue/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Venue Venue = db.Venues.Find(id);
            if (Venue == null)
            {
                return HttpNotFound();
            }
            return View(Venue);
        }

        // GET: Venue/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Venue/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VenueId,Name,Description")] Venue Venue)
        {
            if (ModelState.IsValid)
            {
                db.Venues.Add(Venue);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Venue);
        }

        // GET: Venue/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Venue Venue = db.Venues.Find(id);
            if (Venue == null)
            {
                return HttpNotFound();
            }
            return View(Venue);
        }

        // POST: Venue/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VenueId,Name,Description")] Venue Venue)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Venue).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Venue);
        }

        // GET: Venue/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Venue Venue = db.Venues.Find(id);
            if (Venue == null)
            {
                return HttpNotFound();
            }
            return View(Venue);
        }

        // POST: Venue/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Venue Venue = db.Venues.Find(id);
            db.Venues.Remove(Venue);
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
