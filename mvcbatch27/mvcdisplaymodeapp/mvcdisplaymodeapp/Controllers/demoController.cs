using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdisplaymodeapp.Controllers
{
    public class demoController : Controller
    {
        // GET: demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult index1()
        {
            if(Request.Browser.IsMobileDevice)
            {//comunicating with db to get data for mobile client
                ViewBag.mobiledata = "mobile view data from db";
                return View("mobileview");
            }
            else
            {//communicating with db to get data for desktop client
                ViewBag.desktopdata = "desktop view data from db";
                return View("desktopview");
            }
        }










    }
}