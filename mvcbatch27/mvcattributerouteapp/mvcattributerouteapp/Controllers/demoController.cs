using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcattributerouteapp.Controllers
{
    public class demoController : Controller
    {
        // GET: demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getinfobyname(string id)
        {
            ViewBag.info = id + " product details";
            return View();
        }
        [Route("demo1/gibnp/{name}/{price}")]
        public ActionResult getinfobynameprice(string name,int price)
        {
            ViewBag.info = name + "  " + price + " product details";
            return View();
        }












    }
}