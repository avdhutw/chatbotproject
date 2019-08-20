using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using demoofuserplans.Models;
using demoofuserplans.Contracts;
using System.Data.Entity;

namespace demoofuserplans.Repositories
{
    public class Register_PrepaidPlanRepository : IRegister_PrepaidPlanRepository, IDisposable
    {
        mobile_appEntities2 db;
        public Register_PrepaidPlanRepository()
        {
            db = new mobile_appEntities2();
        }

      

        public void Add_Prepaid_plan(Prepaid_Plan Plan)
        {
            throw new NotImplementedException();
        }


        public void Delete_planbyid(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public List<Prepaid_Plan> GetPrepaid_Plans()
        {
            return db.Prepaid_Plan.ToList();

        }



        public void Update_planbyid(int id)
        {
           // db.Entry(prepaid_Plan).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}