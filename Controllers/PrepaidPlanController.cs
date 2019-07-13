using demoofuserplans.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace demoofuserplans.Controllers
{
    public class PrepaidPlanController : ApiController
    {
        DemochatbootsEntities1 db = new DemochatbootsEntities1();


        [HttpPost]
        public IHttpActionResult Post()
        {
            return Json(db.Prepaid_Plan.ToList());
        }
    }
}
