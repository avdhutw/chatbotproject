using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demoofuserplans.Models;
namespace demoofuserplans.Contracts
{
   public  interface IshowsRepository
    {
        List<show> GetShows(string channelname);
        //get details byid

        show GetShow_byid(int id);
        //add new show
        void Add_show(show show);
        //update show by id 
        void Update_shows(show show);
      //delete show by id
        void Delete_shows(int id);
    }
}
