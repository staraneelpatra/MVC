using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvchtmlcontrolsapp.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult validate(FormCollection f)
        {//para f will receive controls data from index view
            if(f["txtname"]=="peers" && f["txtpassword"]=="info")
            {
                TempData["name"] = f["txtname"];
                return RedirectToAction("welcome", "home");
            }
            else
            {
                ViewBag.msg = "invalid name ..";
                return View("index");//calling index view[webpage]
            }
        }
        public ActionResult welcome()
        {
            return View();
        }
        public ActionResult close()
        {
            return View();
        }
        public ActionResult facebook()
        {
            return Redirect("http://www.facebook.com");
        }









    }
}