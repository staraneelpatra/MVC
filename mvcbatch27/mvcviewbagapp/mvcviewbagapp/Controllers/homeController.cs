using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcviewbagapp.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            List<string> obj = new List<string>();
            obj.Add("asp.net");
            obj.Add("c#");
            obj.Add("sqlserver");
            ViewBag.courses = obj;
            //courses[viewbag var]=obj[normal var]
            //viewbag variable will be accessible with in view but normal var will not be accessible
            return View();
        }









    }
}