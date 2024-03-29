﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using demoofuserplans.Contracts;
using demoofuserplans.Models;
using demoofuserplans.Repositories;

namespace demoofuserplans.Controllers
{
    public class Register_UserController : Controller
    {
       mobile_appEntities2 db = new mobile_appEntities2();

        // GET: Register_User

        IRegister_UserRepository repository;

        public Register_UserController() : this(new Register_UserRepository()) { }

        public Register_UserController(IRegister_UserRepository repository)
        {
            this.repository = repository;
        }
        public ActionResult Index()
        {
            var user = this.repository.GetAll_users();
            
            return View(user);
        }

        // GET: Register_User/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //var user = this.repository.GetUser_byid;
            // user.Find(id);
            var user = this.repository.GetUser_byid(id);
            // User user = db.Users
           // user.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }

            return View(user);
        }

        // GET: Register_User/Create
        public ActionResult Create()
        {
            ViewBag.plans = new SelectList(db.Prepaid_Plan, "Plan_id", "Plan_name");
           // ViewBag.plans = repository.Add_User()

            return View();
        }

        // POST: Register_User/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Client_id,Phone_no,First_name,Last_name,Current_plan,Lastthree_m,Lastsix_m,Lastone_yr,Typeof_user,DOB,Plan_id")] User user)
        {
            if (ModelState.IsValid)
            {
                //db.Users.Add(user);
                //db.SaveChanges();
                repository.Add_User(user);
                return RedirectToAction("Index");
            }

            return View(user);
        }

        // GET: Register_User/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.plans = new SelectList(db.Prepaid_Plan, "Plan_id", "Plan_name");
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var user = this.repository.GetUser_byid(id);
          //  User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Register_User/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Client_id,Phone_no,First_name,Last_name,Current_plan,Lastthree_m,Lastsix_m,Lastone_yr,Typeof_user,DOB,Plan_id")] User user)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(user).State = EntityState.Modified;
                //db.SaveChanges();
                this.repository.update_User(user);

                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: Register_User/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // var user = User.delete_User(id)
           // repository.delete_User(id);

           var user = this.repository.GetUser_byid(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Register_User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //User user = db.Users.Find(id);
            //db.Users.Remove(user);
            //db.SaveChanges();
            repository.delete_ConfirmUser(id);
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
