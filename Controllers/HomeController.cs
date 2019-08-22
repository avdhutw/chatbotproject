using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoofuserplans.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult FDC_BOT()
        {
            ViewBag.Title = "FDC_BOT";

            return View();
        }

        public ActionResult OTD_BOT()
        {
            ViewBag.Title = "OTD_BOT";

            return View();
        }
        public ActionResult TripPlanner_Bot()
        {
            ViewBag.Title = "TripPlanner_Bot";

            return View();
        }
    }
}
