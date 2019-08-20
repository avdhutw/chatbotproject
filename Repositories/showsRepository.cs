using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using demoofuserplans.Contracts;
using demoofuserplans.Models;
namespace demoofuserplans.Repositories
{
    public class showsRepository : IshowsRepository,IDisposable
    {
        mobile_appEntities2 db;

        public showsRepository()
        {
            db = new mobile_appEntities2();

        }

        public void Add_show(show show)
        {
            db = new mobile_appEntities2();
        }


        public void Delete_shows(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public List<show> GetShows()
        {
            return db.shows.ToList();
        }

        public show GetShow_byid(int id)
        {
            return db.shows.Where(x => x.channel_id == id).FirstOrDefault();

        }

     
        public void Update_shows(int id)
        {
            throw new NotImplementedException();
        }

       
    }
}