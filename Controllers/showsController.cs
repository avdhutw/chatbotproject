using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using demoofuserplans.Models;
using demoofuserplans.Contracts;
using demoofuserplans.Repositories;
using System.Text;
using Google.Apis.Dialogflow.v2.Data;

namespace demoofuserplans.Controllers
{
    public class showsController : Controller
    {
        private mobile_appEntities2 db = new mobile_appEntities2();


        IshowsRepository repository;

        public showsController() : this(new showsRepository()) { }

        public showsController(IshowsRepository repository)
        {
            this.repository = repository;
        }


        //public ActionResult getshows()
        //{

        //}

        // GET: shows

        [HttpPost]
        [ActionName("Getshows")]
        public ActionResult Index()
        {
            var sp = new StringBuilder();

            var shows = this.repository.GetShows();
           // return View(shows);
            var response = new GoogleCloudDialogflowV2beta1WebhookResponse();
            return Json(response);


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
        public ActionResult Details(int id)
        {
           // var shows = repository.GetShow_byid();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //var show = db.shows.Contains(  Find(id);
            // var show = db.shows.Find(id);
            var show = this.repository.GetShow_byid(id);

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
                //db.shows.Add(show);
                //db.SaveChanges();
                repository.Add_show(show);

                return RedirectToAction("Index");
            }

            return View(show);
        }

        // GET: shows/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

         var show = this.repository.GetShow_byid(id);
          //  show show = db.shows.Find(id);
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
                //db.Entry(show).State = EntityState.Modified;
                //db.SaveChanges();
                this.repository.Update_shows(show);
                return RedirectToAction("Index");
            }
            return View(show);
        }

        // GET: shows/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var show = this.repository.GetShow_byid(id);
           // show show = db.shows.Find(id);
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
            //show show = db.shows.Find(id);
            //db.shows.Remove(show);
            //db.SaveChanges();
            repository.Delete_shows(id);

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
