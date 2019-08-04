using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcfiltersapp.Controllers
{
    public class demoController : Controller
    {
        // GET: demo
        public ActionResult Index()
        {
            return View();
        }
        [NonAction]
        public ActionResult tutorials()
        {
            return View();
        }
        public ActionResult books()
        {
            return View();
        }
        public ActionResult filenotfound()
        {
            return View();
        }
        
        public ActionResult index1()
        {
            return View();
        }
       // [ValidateInput(false)]
        public ActionResult store(Models.blogreader b)
        {
            return View(b);

        }










    }
}