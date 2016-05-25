using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATrainingSitecore.Controllers
{
    public class MainController : Controller
    {
        // GET: Default
        public ActionResult DigitalAsset()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Countries()
        {
            return View();
        }

        public ActionResult Header()
        {
            var home_item = Sitecore.Context.Database.GetItem("{B4B5438B-08DF-4E60-9BBF-45F5F1508750}");
            var menu_items = home_item.GetChildren().ToArray();
            return View(menu_items);
        }

        public ActionResult Footer()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult WorldwideOffices()
        {
            return View();
        }
        public ActionResult SolutionSuites()
        {
            return View();
        }
        public ActionResult Strategies()
        {
            return View();
        }
        public ActionResult ContextTechnology()
        {
            return View();
        }

    }
}