using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomateJenkinsApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Joe's Pizza!";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Joe's pizza description page!!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Joe's pizza Contact page!!";

            return View();
        }
    }
}