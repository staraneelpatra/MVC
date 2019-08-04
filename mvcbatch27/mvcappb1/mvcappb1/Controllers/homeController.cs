using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcappb1.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            //replace return View with return Content
            return Content("<h2>welcome to mvc</h2>");
        }
        public ActionResult index1()
        {
            return View();//calling webpage[view]
        }
        public ActionResult aboutus()
        {
            return View();
        }






    }
}