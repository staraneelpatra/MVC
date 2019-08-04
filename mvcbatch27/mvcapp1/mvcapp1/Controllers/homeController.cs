using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcapp1.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            return Content("<h2>welcome to asp.net mvc</h2>");
           
        }
        public string m1()
        {
            return "calling m1 method";
        }
        public string m3()
        {
            string s = m2();
            return s;
        }
        private string m2()
        {
            return "hello";
        }
    }










}