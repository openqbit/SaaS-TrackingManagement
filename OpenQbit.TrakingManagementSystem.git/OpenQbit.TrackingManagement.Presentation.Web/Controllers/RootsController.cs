using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OpenQbit.TrakingManagement.Common.Models;
using OpenQbit.TrakingManagement.DAL;

namespace OpenQbit.TrackingManagement.Presentation.Web.Controllers
{
    public class RootsController : Controller
    {
        private DBContext db = new DBContext();

        // GET: Roots
        public ActionResult Index()
        {
            return View(db.Root.ToList());
        }

        // GET: Roots/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Root root = db.Root.Find(id);
            if (root == null)
            {
                return HttpNotFound();
            }
            return View(root);
        }

        // GET: Roots/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Roots/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RootID")] Root root)
        {
            if (ModelState.IsValid)
            {
                db.Root.Add(root);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(root);
        }

        // GET: Roots/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Root root = db.Root.Find(id);
            if (root == null)
            {
                return HttpNotFound();
            }
            return View(root);
        }

        // POST: Roots/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RootID")] Root root)
        {
            if (ModelState.IsValid)
            {
                db.Entry(root).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(root);
        }

        // GET: Roots/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Root root = db.Root.Find(id);
            if (root == null)
            {
                return HttpNotFound();
            }
            return View(root);
        }

        // POST: Roots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Root root = db.Root.Find(id);
            db.Root.Remove(root);
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
