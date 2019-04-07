using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TypedHTMLHelperControl.Models;

namespace TypedHTMLHelperControl.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<string> _country = new List<string>();
            _country.Add("India");
            _country.Add("Russia");
            _country.Add("Afganisthan");
            _country.Add("RSA");
            _country.Add("Japan");

            List<string> _course = new List<string>();
            _course.Add(".NET");
            _course.Add("Java");
            _course.Add("PHP");
            _course.Add("Machine Learning");
            _course.Add("AI");
            _course.Add("MEAN");
            _course.Add("DevOPS");

            ViewBag.Countries = _country;
            ViewBag.Courses = _course;

            return View();
        }

        public ActionResult Save(JobModel u)
        {
            u.Skillset = Request.Form["Courses"];
            return View(u);
        }
    }
}