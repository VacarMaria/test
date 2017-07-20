using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HWEntityFramework.Models;

namespace HWEntityFramework.Controllers
{
    public class StoreLocationsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: StoreLocations
        public ActionResult Index()
        {
            return View(db.StoreLocations.ToList());
        }

        // GET: StoreLocations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StoreLocation storeLocation = db.StoreLocations.Find(id);
            if (storeLocation == null)
            {
                return HttpNotFound();
            }
            return View(storeLocation);
        }

        // GET: StoreLocations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StoreLocations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,LocationName")] StoreLocation storeLocation)
        {
            if (ModelState.IsValid)
            {
                db.StoreLocations.Add(storeLocation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(storeLocation);
        }

        // GET: StoreLocations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StoreLocation storeLocation = db.StoreLocations.Find(id);
            if (storeLocation == null)
            {
                return HttpNotFound();
            }
            return View(storeLocation);
        }

        // POST: StoreLocations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,LocationName")] StoreLocation storeLocation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(storeLocation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(storeLocation);
        }

        // GET: StoreLocations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StoreLocation storeLocation = db.StoreLocations.Find(id);
            if (storeLocation == null)
            {
                return HttpNotFound();
            }
            return View(storeLocation);
        }

        // POST: StoreLocations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StoreLocation storeLocation = db.StoreLocations.Find(id);
            db.StoreLocations.Remove(storeLocation);
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
