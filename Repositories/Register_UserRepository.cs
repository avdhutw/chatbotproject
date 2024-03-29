﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using demoofuserplans.Models;
using demoofuserplans.Contracts;
using System.Data.Entity;

namespace demoofuserplans.Repositories
{
    public class Register_UserRepository : IRegister_UserRepository , IDisposable
    {
        mobile_appEntities2 db;
        public Register_UserRepository()
        {
            db = new mobile_appEntities2();
        }

        public void Add_User(User user)
        {

            db.Users.Add(user);
            db.SaveChanges();
        }

        public void delete_User(int id)
        {
            User user = db.Users.Find(id);

        }
        public void delete_ConfirmUser(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll_users()
        {
            // throw new NotImplementedException();
            return db.Users.ToList();
        }

        public User GetUser_byid(int id)
        {

            return db.Users.Find(id);


        }

        public void update_User(User user)
        {
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
            //  db.Users.Entry(user)
        }
    }
}