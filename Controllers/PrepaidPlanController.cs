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

namespace demoofuserplans.Controllers
{
    public class PrepaidPlanController : ApiController
    {
        DemochatbootsEntities1 db = new DemochatbootsEntities1();
       

    //private static readonly JsonParser jsonParser =
    //  new JsonParser(JsonParser.Settings.Default.WithIgnoreUnknownFields(true));

    [HttpPost]
    [ActionName("GetPlans")]
         public  IHttpActionResult Post()
        {
     
      var response = new GoogleCloudDialogflowV2beta1WebhookResponse();

          var sp = new StringBuilder();
          db.Prepaid_Plan.ToList().ForEach((x) =>
         {
           sp.Append($"{ x.Plan_name}  is avaible at {x.Datalimit_per}GB/per day" + Environment.NewLine);
         });

          response.FulfillmentText = sp.ToString();
                return Json(response);
            }
    }
}
