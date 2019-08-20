using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using demoofuserplans.Models;

namespace demoofuserplans.Contracts
{
   public interface IPrepaid_PlanRepository
    {

        //Get All Prepaid Plans
        List<Prepaid_Plan> GetPrepaid_Plans();
        //Get A Prepaid plan by ID 
        Prepaid_Plan GetPrepaid_Plan_By_id(int id);
       //Get All Plans Above a GB Limit
        List<Prepaid_Plan> GetPrepaid_Plans_Suggestion(float GB);
        //Add a new Prepaid Plan
        void Add_Prepaid_Plan(Prepaid_Plan plan);
        //Delete a preapid Plan
        void Delete_Prepaid_Plan(int id);
      //Update A Prepaid plan
        void Update_Prepaid_Plan(Prepaid_Plan plan);

    }
}
