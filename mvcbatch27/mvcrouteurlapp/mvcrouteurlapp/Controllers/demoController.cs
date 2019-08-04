using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcrouteurlapp.Controllers
{
    public class demoController : Controller
    {
        // GET: demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getreportbymonth(int id1=0)
        {
            ViewBag.info = id1 + " month report details";
            return View();
        }
        public ActionResult getreportbymonthyear(int month,int year)
        {
            ViewBag.info = month + "/" + year + "  report details";
            return View();
        }










    }
}