using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using mvctaghelpersapp.Models;
using Microsoft.Framework.Configuration;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace mvctaghelpersapp.Controllers
{
    public class demoController : Controller
    {
        IConfiguration config;
        // GET: /<controller>/
        public demoController(IConfiguration c)
        {
            config = c;
        }
        public string m1()
        {
            return "hello ajax";
        }
        public IActionResult Index()
        {
            ViewBag.name = config.Get("constr");
            ViewBag.s = config.GetConfigurationSection("foo").Get("bar");
            List<SelectListItem> obj1 = new List<SelectListItem>();
            obj1.Add(new SelectListItem { Text = ".net", Value = ".net" });
            obj1.Add(new SelectListItem { Text = "java", Value = "java" });
            obj1.Add(new SelectListItem { Text = "php", Value = "php" });
            obj1.Add(new SelectListItem { Text = "hadoop", Value = "hadoop" });
            List<string> obj2 = new List<string>();
            obj2.Add("-select-");
            obj2.Add("india");
            obj2.Add("usa");
            obj2.Add("japan");
            obj2.Add("uk");
            ViewBag.skillsets = obj1;
            ViewBag.countries = obj2;
            return View();
        }
        public ActionResult store(usermodel u)
        {//para u will receive data from index view
            u.skillset = Request.Form["skillset"];
            if (ModelState.IsValid)
                return View(u);
            else
            {
                List<SelectListItem> obj1 = new List<SelectListItem>();
                obj1.Add(new SelectListItem { Text = ".net", Value = ".net" });
                obj1.Add(new SelectListItem { Text = "java", Value = "java" });
                obj1.Add(new SelectListItem { Text = "php", Value = "php" });
                obj1.Add(new SelectListItem { Text = "hadoop", Value = "hadoop" });
                List<string> obj2 = new List<string>();
                obj2.Add("-select-");
                obj2.Add("india");
                obj2.Add("usa");
                obj2.Add("japan");
                obj2.Add("uk");
                ViewBag.skillsets = obj1;
                ViewBag.countries = obj2;
                return View("index");
               // return RedirectToAction("index", "demo");
            }
                
       }










    }
}
