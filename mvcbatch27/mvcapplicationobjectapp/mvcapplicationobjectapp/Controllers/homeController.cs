using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcapplicationobjectapp.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult store()
        {//read comment submitted by user with index view
            HttpContext.Application["comments"] = HttpContext.Application["comments"].ToString() + Request.Form["t1"] + "<hr>";
            return View("index");
        }










    }
}