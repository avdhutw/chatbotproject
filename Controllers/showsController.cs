using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using demoofuserplans.Models;

namespace demoofuserplans.Controllers
{
    public class showsController : Controller
    {
        private mobile_appEntities2 db = new mobile_appEntities2();

        // GET: shows
        public ActionResult Index()
        {
            return View(db.shows.ToList());
        }


        //public JsonResult searchstring(string inputstring)
        //{
        //    var data = db.shows.Where(x => x.channel_name.Contains(inputstring)).ToList();

        //    return Json(data, JsonRequestBehavior.AllowGet);
        //}
        //[HttpPost]
        //[ActionName("TestPost1")]
        public JsonResult searchApi(string inputstring)
        {


            var data = db.shows.Where(x => x.channel_name.Contains(inputstring)).ToList();
           

            return Json(data,JsonRequestBehavior.AllowGet);
        }


        // GET: shows/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //var show = db.shows.Contains(  Find(id);
            var show = db.shows.Find(id);
            if (show == null)
            {
                return HttpNotFound();
            }
            return View(show);
        }

        // GET: shows/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: shows/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "channel_id,channel_name,show_name")] show show)
        {
            if (ModelState.IsValid)
            {
                db.shows.Add(show);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(show);
        }

        // GET: shows/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            show show = db.shows.Find(id);
            if (show == null)
            {
                return HttpNotFound();
            }
            return View(show);
        }

        // POST: shows/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "channel_id,channel_name,show_name")] show show)
        {
            if (ModelState.IsValid)
            {
                db.Entry(show).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(show);
        }

        // GET: shows/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            show show = db.shows.Find(id);
            if (show == null)
            {
                return HttpNotFound();
            }
            return View(show);
        }

        // POST: shows/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            show show = db.shows.Find(id);
            db.shows.Remove(show);
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
