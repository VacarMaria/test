using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EventsEntityFrmVs.Models;

namespace EventsEntityFrmVs.Controllers
{
    public class CommentModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CommentModels
        public ActionResult Index()
        {
            var commentModels = db.CommentModels.Include(c => c.Event);
            return View(commentModels.ToList());
        }

        // GET: CommentModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CommentModel commentModel = db.CommentModels.Find(id);
            if (commentModel == null)
            {
                return HttpNotFound();
            }
            return View(commentModel);
        }

        // GET: CommentModels/Create
        public ActionResult Create()
        {
            ViewBag.EventId = new SelectList(db.EventModels, "Id", "Title");
            return View();
        }

        // POST: CommentModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Text,Date,EventId")] CommentModel commentModel)
        {
            if (ModelState.IsValid)
            {
                commentModel.Date = DateTime.Now;
                db.CommentModels.Add(commentModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EventId = new SelectList(db.EventModels, "Id", "Title", commentModel.EventId);
            return View(commentModel);
        }

        // GET: CommentModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CommentModel commentModel = db.CommentModels.Find(id);
            if (commentModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.EventId = new SelectList(db.EventModels, "Id", "Title", commentModel.EventId);
            return View(commentModel);
        }

        // POST: CommentModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Text,Date,EventId")] CommentModel commentModel)
        {
            if (ModelState.IsValid)
            {
                commentModel.Date = DateTime.Now;
                db.Entry(commentModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EventId = new SelectList(db.EventModels, "Id", "Title", commentModel.EventId);
            return View(commentModel);
        }

        // GET: CommentModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CommentModel commentModel = db.CommentModels.Find(id);
            if (commentModel == null)
            {
                return HttpNotFound();
            }
            return View(commentModel);
        }

        // POST: CommentModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CommentModel commentModel = db.CommentModels.Find(id);
            db.CommentModels.Remove(commentModel);
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
