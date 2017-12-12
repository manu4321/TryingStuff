using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TryingStuffCommon.Model;

namespace TryingStuffWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                IEntryPointService service = new EntryPointServiceClient();
                ViewBag.Message = "First message: " + service.GetRatings();
                ViewBag.Ratings = service.GetRatings();
            }
            catch(Exception e)
            {
                ViewBag.Message = "Error was: " +  e.Message;
                ViewBag.Ratings = new Rating[0];
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}