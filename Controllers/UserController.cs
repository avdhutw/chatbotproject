using demoofuserplans.Models;
using Google.Apis.Dialogflow.v2.Data;
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
        public IHttpActionResult TestPost([FromBody]dynamic Body)
        {
            DateTime date = Body.queryResult.parameters.date[0].Value;
            string phoneNumber = Body.queryResult.parameters["phone-number"][0].Value;

            var item = "your birthdate is" + date.ToString() + " and " + phoneNumber + "from API";

            var response = new GoogleCloudDialogflowV2beta1WebhookResponse();

            response.FulfillmentText = item;
            return Json(response);
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
