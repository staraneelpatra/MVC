using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvclayoutpageapp.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult aboutus()
        {
            return View();
        }
        public ActionResult contactus()
        {
            return View();
        }
        public ActionResult tutorials()
        {
            return View();
        }
        public ActionResult books()
        {
            return View();
        }



    }
}