using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcactionresulttypesapp.Controllers
{
    public class homeController : Controller
    {
        public ContentResult contentdemo()
        {
            return Content("<h3>contentresult method</h3>");
        }
        public ViewResult viewdemo()
        {
            return View();
        }
        public JsonResult jsondemo()
        {
            List<string> obj = new List<string>();
            obj.Add("asp.net");
            obj.Add("c#");
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        public FileResult filedemo()
        {
            return File("~/videos/movie1.mp4", "video/mp4", "mirchimovie.mp4");
        }
        public ActionResult Index()
        {
            return View();
        }




    }
}