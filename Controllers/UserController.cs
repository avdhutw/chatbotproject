using demoofuserplans.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace demoofuserplans.Controllers
{
    
    public class UserController : ApiController
    {
        DemochatbootsEntities1 db = new DemochatbootsEntities1();

       

        [HttpPost]
        public IHttpActionResult Post()
        {
            return Json(db.Users.ToList());
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            return Json(db.Users.Where(i => i.Client_id == id).FirstOrDefault<User>());


        }




        //[HttpPost]
        //public async Task<IHttpActionResult> InsertUser(User user)
        //{
           

        //    db.Users.Add(user);
        //    await db.SaveChangesAsync();

        //    return Ok();
        //}

    }
}
