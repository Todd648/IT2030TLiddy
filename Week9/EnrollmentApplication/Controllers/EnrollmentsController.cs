﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EnrollmentApplication.Models;

namespace EnrollmentApplication.Controllers
{
    public class EnrollmentsController : Controller
    {
        private EnrollmentDB db = new EnrollmentDB();

        // GET: Enrollments
        public ActionResult Index()
        {
            var enrollments = db.Enrollments.Include(e => e.Course).Include(e => e.Student);
            return View(enrollments.ToList());
        }

        // GET: Enrollments/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enrollment enrollment = db.Enrollments.Find(id);
            if (enrollment == null)
            {
                return HttpNotFound();
            }
            return View(enrollment);
        }

        // GET: Enrollments/Create
        public ActionResult Create()
        {
            ViewBag.CourseID = new SelectList(db.Courses, "CourseID", "CourseTitle");
            ViewBag.StudentID = new SelectList(db.Students, "StudentID", "LastName");
            return View();
        }

        // POST: Enrollments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EnrollmentID,StudentID,CourseID,IsActive,AssignedCampus,EnrollmentSemester,EnrollmentYear,Notes,Student,Course")] Enrollment enrollment)
        {
            if (ModelState.IsValid)
            {
                db.Enrollments.Add(enrollment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseID = new SelectList(db.Courses, "CourseID", "CourseTitle", enrollment.CourseID);
            ViewBag.StudentID = new SelectList(db.Students, "StudentID", "LastName", enrollment.StudentID);
            return View(enrollment);
        }

        // GET: Enrollments/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enrollment enrollment = db.Enrollments.Find(id);
            if (enrollment == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseID = new SelectList(db.Courses, "CourseID", "CourseTitle", enrollment.CourseID);
            ViewBag.StudentID = new SelectList(db.Students, "StudentID", "LastName", enrollment.StudentID);
            return View(enrollment);
        }

        // POST: Enrollments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EnrollmentID,StudentID,CourseID,IsActive,AssignedCampus,EnrollmentSemester,EnrollmentYear,Notes,Student,Course")] Enrollment enrollment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(enrollment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseID = new SelectList(db.Courses, "CourseID", "CourseTitle", enrollment.CourseID);
            ViewBag.StudentID = new SelectList(db.Students, "StudentID", "LastName", enrollment.StudentID);
            return View(enrollment);
        }

        // GET: Enrollments/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enrollment enrollment = db.Enrollments.Find(id);
            if (enrollment == null)
            {
                return HttpNotFound();
            }
            return View(enrollment);
        }

        // POST: Enrollments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Enrollment enrollment = db.Enrollments.Find(id);
            db.Enrollments.Remove(enrollment);
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
        public ActionResult StudentSearch(string s)
        {
            var students = GetStudents(s);
            return PartialView("StudentSearch", students);
        }

        private List<Student> GetStudents(string searchString)
        {
            return db.Students
                .Where(a => a.LastName.Contains(searchString) || a.FirstName.Contains(searchString))
                .ToList();
        }
        public ActionResult CourseSearch(string c)
        {
            var courses = GetCourses(c);
            return PartialView("CourseSearch", courses);
        }

        private List<Course> GetCourses(string searchString)
        {
            return db.Courses
                .Where(a => a.CourseTitle.Contains(searchString))
                .ToList();
        }

    }
}
