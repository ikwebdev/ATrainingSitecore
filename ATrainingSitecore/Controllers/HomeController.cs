using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATrainingSitecore.Controllers
{
    public class HomeController : Controller
    {
        // GET: Default
        public ActionResult HomeLeftSide()
        {
            return View();
        }

        public ActionResult HomeMiddle()
        {
            return View();
        }

        public ActionResult HomeRightSide()
        {
            return View();
        }

        public ActionResult Slides()
        {
            return View();
        }
    }
}