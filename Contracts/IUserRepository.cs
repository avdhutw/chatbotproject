using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demoofuserplans.Models;
namespace demoofuserplans.Contracts
{
   public interface IUserRepository
    {
        List<Prepaid_Plan> All_plans();
        //get user by id 
        User GetUser_byid(int id);
        //uses info
        User Getuses_info(float GB);
        //plan info by phone no and dob

    }
}
