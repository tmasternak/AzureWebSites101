using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using log4net;

namespace AzureWebsite101.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

            logger.Info("Hello from index");

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