using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcstrongviewapp.Models;
namespace mvcstrongviewapp.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            studentmodel obj1 = new studentmodel { studid = "s001", studname = "raju", studphoto = "1.jpg" };
            return View(obj1);
        }
        public ActionResult index1()
        {
            List<studentmodel> obj2 = new List<studentmodel>();
            obj2.Add(new studentmodel { studid = "s001", studname = "raju", studphoto = "1.jpg" });
            obj2.Add(new studentmodel { studid = "s002", studname = "ramu", studphoto = "2.jpg" });
            return View(obj2);
        }








    }
}