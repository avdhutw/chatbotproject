using demoofuserplans.Models;
using Google.Apis.Dialogflow.v2.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

using demoofuserplans.Contracts;
using demoofuserplans.Repositories;


namespace demoofuserplans.Controllers
{
    
    public class UserController : ApiController
    {
        mobile_appEntities2 db = new mobile_appEntities2();

        IUserRepository repository;

        public UserController() : this(new UserRepository()) { }

        public UserController(IUserRepository repository)
        {
            this.repository = repository;
        }

        //[HttpPost]
        //public IHttpActionResult Post()
        //{
        //    return Json(db.Users.ToList());
        //}


        [HttpPost]
        [ActionName("TestPost")]
        public IHttpActionResult TestPost([FromBody]dynamic Body)
        {
            string item = "";
            string action = Body.queryResult.action;
            switch (action.ToLower())
            {
                case "getplans":
                    item = this.GetAllPlans();
                    break;
                case "getmyplan":

                    DateTime date = Body.queryResult.parameters.date[0].Value;
                    string phoneNumber = Body.queryResult.parameters["phoneNumber"][0].Value;

                    item = this.Planinfo(phoneNumber, date);
                    break;
                case "usesinfo":
                    DateTime date1 = Body.queryResult.parameters.date[0].Value;
                    string phoneNumber1 = Body.queryResult.parameters["phoneNumber"][0].Value;

                    item = this.usesinfo(phoneNumber1,date1);
                    break;

                default:
                    item = "did not understand you";
                    break;
            }


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
                    var plan = db.Prepaid_Plan.Where((p) => p.Plan_id == user.Plan_id).FirstOrDefault();
                    if (plan != null)
                        return plan.getPlaninfo();
                }
            };
            return "You dont have a prepaid plan...";
        }

        private string GetAllPlans()
        {
            var sp = new StringBuilder();
            var plans = this.repository.All_plans();

            plans.ForEach((x) =>
            {
                sp.Append($"{ x.Plan_name}  is avaible at {x.Datalimit_per}GB/per day" + Environment.NewLine);
            });

            return sp.ToString();

        }

        private string usesinfo(string phonenmber, DateTime dateofbirth)
        {
            var user = db.Users.Where((x) => x.Phone_no == phonenmber
          && DbFunctions.TruncateTime(x.DOB) == DbFunctions.TruncateTime(dateofbirth)).ToList();
            var sp = new StringBuilder();
            user.ForEach((x) =>
            {
                sp.Append($"{x.Lastthree_m}GB {x.Lastsix_m}GB {x.Lastone_yr}GB" + Environment.NewLine);
            });
            return sp.ToString();

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
