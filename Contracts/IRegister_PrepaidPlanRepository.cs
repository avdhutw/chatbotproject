﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demoofuserplans.Models;
namespace demoofuserplans.Contracts
{
   public  interface IRegister_PrepaidPlanRepository
    {
        //get all prepaidplan
        List<Prepaid_Plan> GetPrepaid_Plans();
        //add prepaid plan
        void Add_Prepaid_plan(Prepaid_Plan Plan);
      //update preapaid plan by id 
        void Update_planbyid(int id);
        //delete prepaid plan by id 
        void Delete_planbyid(int id);
    }
}