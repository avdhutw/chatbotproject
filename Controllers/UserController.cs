using demoofuserplans.Models;
using Google.Apis.Dialogflow.v2.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

            var item = this.Planinfo(phoneNumber, date);

            var response = new GoogleCloudDialogflowV2beta1WebhookResponse();

            response.FulfillmentText = item;
            return Json(response);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            return Json(db.Users.Where(i => i.Client_id == id).FirstOrDefault<User>());


        }

        private string Planinfo(string phonenmber, DateTime dateofbirth)
        {


            var user = db.Users.Where((x) => x.Phone_no == phonenmber
            && DbFunctions.TruncateTime(x.DOB) == DbFunctions.TruncateTime(dateofbirth)).FirstOrDefault();

            {
                if (user != null)
                {
                    var plan = db.Prepaid_Plan.Where((p) => p.Plan_id == user.Client_id).FirstOrDefault();
                    if (plan != null)
                        return plan.getPlaninfo();


                }


            };
            return "You dont have a prepaid plan...";
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
