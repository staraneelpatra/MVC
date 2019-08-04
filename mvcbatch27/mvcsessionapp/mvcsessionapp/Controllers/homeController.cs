using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcsessionapp.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            Session["scss"] = "";
            return View();
        }

        public ActionResult store()
        {
            Session["scss"] = Request.Form["s1"];//it returns user selected option value[standard.css|classic.css]
            return View("index");
        }
        public ActionResult register()
        {
            return View();
        }
        public ActionResult login()
        {
            return View();
        }





    }
}