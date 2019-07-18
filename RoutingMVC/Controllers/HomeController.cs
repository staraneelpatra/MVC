using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Content("<h2>hello </h2>");
        }

        public ActionResult Sss(int id)
        {
            return Content("<h1>Welcome " + id + "</h1>");
        }
        [Route("home1/gadi/{name}/{cc}")]
        public ActionResult BIKE(string name, int cc)
        {
            return Content("<h1>Welcome " + name+" with "  + cc+"cc</h1>");
        }
        
    }
}

