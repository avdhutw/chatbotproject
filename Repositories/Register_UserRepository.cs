using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using demoofuserplans.Models;
using demoofuserplans.Contracts;
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

            db = new mobile_appEntities2();
        }

        public void delete_User(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll_users()
        {
            throw new NotImplementedException();
        }

        public User GetUser_byid(int id)
        {

            return db.Users.Find(id);


        }

        public void update_User(User user)
        {
            throw new NotImplementedException();
        }
    }
}