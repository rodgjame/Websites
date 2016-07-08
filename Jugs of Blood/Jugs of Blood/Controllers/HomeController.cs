using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jugs_of_Blood.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "JUGS OF BLOOD IS A KICK ASS THRASH METAL BAND. THEY ARE LOUD AND RAD AND GIVE ZERO FUCKS. LISTEN TO THEM. SEE THEM LIVE. GET WASTED. BRING YOUR FRIENDS.";

            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "JUGS OF BLOOD WOULD APPRECIATE IT IF YOU GAVE THEM A RECORD DEAL OR BOOKED THEM AT YOUR FINE ESTABLISHMENT.";

            return View();
        }
    }
}