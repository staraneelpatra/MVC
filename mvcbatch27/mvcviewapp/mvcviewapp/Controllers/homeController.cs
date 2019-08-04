using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcviewapp.Controllers
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
            return View("contactus");
        }
        public ActionResult contactus()
        {
            return View();
        }
    }
}