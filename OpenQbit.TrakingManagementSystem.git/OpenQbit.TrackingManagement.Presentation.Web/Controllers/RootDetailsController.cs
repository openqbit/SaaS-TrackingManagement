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
    public class RootDetailsController : Controller
    {
        private DBContext db = new DBContext();

        // GET: RootDetails
        public ActionResult Index()
        {
            return View(db.RootDetail.ToList());
        }

        // GET: RootDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RootDetail rootDetail = db.RootDetail.Find(id);
            if (rootDetail == null)
            {
                return HttpNotFound();
            }
            return View(rootDetail);
        }

        // GET: RootDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RootDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RootDetailID,City,Time,RootID")] RootDetail rootDetail)
        {
            if (ModelState.IsValid)
            {
                db.RootDetail.Add(rootDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rootDetail);
        }

        // GET: RootDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RootDetail rootDetail = db.RootDetail.Find(id);
            if (rootDetail == null)
            {
                return HttpNotFound();
            }
            return View(rootDetail);
        }

        // POST: RootDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RootDetailID,City,Time,RootID")] RootDetail rootDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rootDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rootDetail);
        }

        // GET: RootDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RootDetail rootDetail = db.RootDetail.Find(id);
            if (rootDetail == null)
            {
                return HttpNotFound();
            }
            return View(rootDetail);
        }

        // POST: RootDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RootDetail rootDetail = db.RootDetail.Find(id);
            db.RootDetail.Remove(rootDetail);
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
