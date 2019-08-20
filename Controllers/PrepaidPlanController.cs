using demoofuserplans.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Google.Apis.Dialogflow.v2.Data;
using System.Text;
using Google.Protobuf;
using System.IO;

using demoofuserplans.Contracts;
using demoofuserplans.Repositories;

namespace demoofuserplans.Controllers
{
    public class PrepaidPlanController : ApiController
    {
        mobile_appEntities2 db = new mobile_appEntities2();


        IPrepaid_PlanRepository repository;

        public PrepaidPlanController() : this(new Prepaid_PlanRepository()) { }

        public PrepaidPlanController(IPrepaid_PlanRepository repository)
        {
            this.repository = repository;
        }

        //private static readonly JsonParser jsonParser ==
        //  new JsonParser(JsonParser.Settings.Default.WithIgnoreUnknownFields(true));

        [HttpPost]
    [ActionName("GetPlans")]
         public  IHttpActionResult Post()
        {
     
      var response = new GoogleCloudDialogflowV2beta1WebhookResponse();



            var sp = new StringBuilder();

            var plans = this.repository.GetPrepaid_Plans();
          plans.ForEach((x) =>
         {
           sp.Append($"{ x.Plan_name}  is avaible at {x.Datalimit_per}GB/per day" + Environment.NewLine);
         });

          response.FulfillmentText = sp.ToString();
                return Json(response);
            }
    }
}
