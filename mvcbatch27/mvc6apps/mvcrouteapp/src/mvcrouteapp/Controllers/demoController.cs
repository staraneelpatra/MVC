using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace mvcrouteapp.Controllers
{
    
    public class demoController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

       // [Route("demo1/getnp/{name}/{price}")]
        public ActionResult getinfobynameprice(string name,int price)
        {
            ViewBag.info = name + "  " + price + " prod info";
            return View();
        }

        public ActionResult getinfobyname(string id)
        {
            ViewBag.info = id + " product info";
            return View();
        }
        [Route("demo1/getnpc/{catename}/{price}/{a?}")]
        public ActionResult getcp(string catename, int price, int a)
        {
            ViewBag.info = catename + "  " + price + " prods info";
            return View();
        }










    }
}
