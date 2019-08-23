using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            db.shows.Add(show);
            db.SaveChanges();
        }


        public void Delete_shows(int id)
        {
            show show = db.shows.Find(id);
            db.shows.Remove(show);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public List<show> GetShows(string channelname)
        {

            return db.shows.Where(x =>x.channel_name == channelname).ToList();
        }

        public show GetShow_byid(int id)
        {
            return db.shows.Where(x => x.channel_id == id).FirstOrDefault();

        }

     
        public void Update_shows(int id)
        {
            show show = db.shows.Find(id);
        }

        public void Update_shows(show show)
        {
            db.Entry(show).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}