using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movies.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index() 
        {
            //return Hello World!!!;
            return View();
        }

        public ActionResult Welcome(string name, int numTimes = 0) 
        {
            ViewBag.name = name;
            ViewBag.numTimes = numTimes;
            //return String.Format("Welcome {0}!!! {1}", name, numTimes);
            return View();
        }
    }
}