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

        //[HttpPost]
        //public IHttpActionResult Post()
        //{
        //    return Json(db.Users.ToList());
        //}


        [HttpPost]
        [ActionName("TestPost")]
        public IHttpActionResult TestPost([FromBody] dynamic Body)
        {
            DateTime date = Body.First.parameters["date"][0];
            string phoneNumber = Body.First.parameters["phone-number"][0];

            var item = "your birthdate is" + date.ToString() + " and " + phoneNumber + "from API";

            return Json(new { speech = item , displayText = item });
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
