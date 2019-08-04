using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvctypedapp.Models;
namespace mvctypedapp.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            List<string> obj1 = new List<string>();//listitem text and value is same
            obj1.Add("india");
            obj1.Add("usa");
            obj1.Add("japan");
            List<SelectListItem> obj2 = new List<SelectListItem>();//listitem text and value is different
            obj2.Add(new SelectListItem { Text = ".net", Value = ".net" });
            obj2.Add(new SelectListItem { Text = "java", Value = "java" });
            obj2.Add(new SelectListItem { Text = "php", Value = "php" });
            obj2.Add(new SelectListItem { Text = "hadoop", Value = "hadoop" });
            ViewBag.countries = obj1;
            ViewBag.skillsets = obj2;
            return View();
        }
        public ActionResult store(jobmodel j)
        {//index view typed helper controls data will be binded to jobmodel[j] properties automatically
           // j.skillset = Request.Form["skillset"];
            //by default skillset will be assigned with only one listitem of listbox,if it is more than one explicitly we need to assign
            return View(j);
        }

















    }
}