using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using demoofuserplans.Contracts;
using demoofuserplans.Models;

namespace demoofuserplans.Repositories
{
    public class Prepaid_PlanRepository : IPrepaid_PlanRepository, IDisposable
    {
        mobile_appEntities2 db;

        public Prepaid_PlanRepository()
        {
            db = new mobile_appEntities2();
        }

        public void Add_Prepaid_Plan(Prepaid_Plan plan)
        {
            throw new NotImplementedException();
        }

        public void Delete_Prepaid_Plan(int id)
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

        public List<Prepaid_Plan> GetPrepaid_Plans_Suggestion(float GB)
        {
            return db.Prepaid_Plan.ToList();
        }

        public Prepaid_Plan GetPrepaid_Plan_By_id(int id)
        {
            return db.Prepaid_Plan.Where(x => x.Plan_id == id).FirstOrDefault();
        }

        public void Update_Prepaid_Plan(Prepaid_Plan plan)
        {
            throw new NotImplementedException();
        }
    }
}