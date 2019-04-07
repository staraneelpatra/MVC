using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTMLControlViewBagTempData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Validate(FormCollection f)
        {
            string un = f["txtun"];
            string pwd = f["txtpwd"];
             
            if (un == "anil" && pwd == "anil")
            {
                TempData["uname"] = un;
                return RedirectToAction("Welcome", "home");
            }
            else
            {
                ViewBag.uname = un;
                ViewBag.msg = "Failed Authentication";
                return View("index");
            }
        }
        public ActionResult Welcome()
        {
            return View();
        }
    }
}