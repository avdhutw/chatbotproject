using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demoofuserplans.Models;

namespace demoofuserplans.Contracts
{
   public  interface IRegister_UserRepository
    {
        //get all user
        List<User> GetAll_users();
        //get user by id
        User GetUser_byid(int id);
        //add user
        void Add_User(User user);
       //update user 
        void update_User(User user);
        //delete user byid
        void delete_User(int id);

        void delete_ConfirmUser(int id);

      

    }
}
