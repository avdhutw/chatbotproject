using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using demoofuserplans.Contracts;
using demoofuserplans.Repositories;
using demoofuserplans.Models;
namespace demoofuserplans.Controllers
{
    public class Register_PlanController : Controller
    {
         mobile_appEntities2 db = new mobile_appEntities2();

        IRegister_UserRepository repository;

        public Register_PlanController() : this(new Register_PrepaidPlanRepository()) { }

        public Register_PlanController(IRegister_PrepaidPlanRepository repository)
        {
          //  this.repository = repository;
        }

        // GET: Register_Plan
        public ActionResult Index()
        {
           // var plans = this.repository.GetPrepaid_Plans();

            return View(db.Prepaid_Plan.ToList());
        }

        // GET: Register_Plan/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Prepaid_Plan prepaid_Plan = db.Prepaid_Plan.Find(id);
            if (prepaid_Plan == null)
            {
                return HttpNotFound();
            }
            return View(prepaid_Plan);
        }

        // GET: Register_Plan/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Register_Plan/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Plan_id,Plan_name,Noof_day,Datalimit_per,Noof_sms,Noof_calls,Isunlimitedcalling_enabled")] Prepaid_Plan prepaid_Plan)
        {
            if (ModelState.IsValid)
            {
                db.Prepaid_Plan.Add(prepaid_Plan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(prepaid_Plan);
        }

        // GET: Register_Plan/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prepaid_Plan prepaid_Plan = db.Prepaid_Plan.Find(id);
            if (prepaid_Plan == null)
            {
                return HttpNotFound();
            }
            return View(prepaid_Plan);
        }

        // POST: Register_Plan/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Plan_id,Plan_name,Noof_day,Datalimit_per,Noof_sms,Noof_calls,Isunlimitedcalling_enabled")] Prepaid_Plan prepaid_Plan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(prepaid_Plan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(prepaid_Plan);
        }

        // GET: Register_Plan/Delete/5
        public ActionResult Delete(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }


           
            Prepaid_Plan prepaid_Plan = db.Prepaid_Plan.Find(id);
            if (prepaid_Plan == null)
            {
                return HttpNotFound();
            }
            return View(prepaid_Plan);
        }

        // POST: Register_Plan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Prepaid_Plan prepaid_Plan = db.Prepaid_Plan.Find(id);
            db.Prepaid_Plan.Remove(prepaid_Plan);
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
