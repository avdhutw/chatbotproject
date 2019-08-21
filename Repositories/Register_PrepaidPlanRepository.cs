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

      

        public void Add_Prepaid_plan(Prepaid_Plan prepaid_Plan)
        {
            db.Prepaid_Plan.Add(prepaid_Plan);
            db.SaveChanges();
        }


        public void Delete_planbyid(int id)
        {
            Prepaid_Plan prepaid_Plan = db.Prepaid_Plan.Find(id);
            db.Prepaid_Plan.Remove(prepaid_Plan);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public Prepaid_Plan GetPrepaid_Planbyid(int id)
        {
            return db.Prepaid_Plan.Find(id);
        }

        public List<Prepaid_Plan> GetPrepaid_Plans()
        {
            return db.Prepaid_Plan.ToList();

        }

        public void update_plan(Prepaid_Plan prepaid_Plan)
        {
            db.Entry(prepaid_Plan).State = EntityState.Modified;
            db.SaveChanges();
        }


        public void Update_planbyid(int id)
        {
            throw new NotImplementedException();
        }
    }
}