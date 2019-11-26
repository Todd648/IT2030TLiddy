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
    public class OrganizerController : Controller
    {
        private FinalEventApplicationDB db = new FinalEventApplicationDB();

        // GET: Organizer
        public ActionResult Index()
        {
            return View(db.Organizers.ToList());
        }

        // GET: Organizer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Organizer Organizer = db.Organizers.Find(id);
            if (Organizer == null)
            {
                return HttpNotFound();
            }
            return View(Organizer);
        }

        // GET: Organizer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Organizer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrganizerId,Name")] Organizer Organizer)
        {
            if (ModelState.IsValid)
            {
                db.Organizers.Add(Organizer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Organizer);
        }

        // GET: Organizer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Organizer Organizer = db.Organizers.Find(id);
            if (Organizer == null)
            {
                return HttpNotFound();
            }
            return View(Organizer);
        }

        // POST: Organizer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrganizerId,Name")] Organizer Organizer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Organizer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Organizer);
        }

        // GET: Organizer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Organizer Organizer = db.Organizers.Find(id);
            if (Organizer == null)
            {
                return HttpNotFound();
            }
            return View(Organizer);
        }

        // POST: Organizer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Organizer Organizer = db.Organizers.Find(id);
            db.Organizers.Remove(Organizer);
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
