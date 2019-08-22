using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using demoofuserplans.Contracts;
using demoofuserplans.Models;
namespace demoofuserplans.Repositories
{
    public class UserRepository : IUserRepository, IDisposable
    {
        mobile_appEntities2 db;

        public UserRepository()
        {
            db = new mobile_appEntities2();
        }

        public List<Prepaid_Plan> All_plans()
        {
            return db.Prepaid_Plan.ToList();

        }

        public void Dispose()
        {
            db.Dispose();
        }

        public User GetUser_byid(int id)
        {
            throw new NotImplementedException();
        }

        public User Getuses_info(float GB)
        {
            throw new NotImplementedException();
        }
      

        public List<show> shows()
        {
            return db.shows.ToList();
        }
    }
}