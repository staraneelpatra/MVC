using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcdiapp.repositories;
    
namespace mvcdiapp.Controllers
{
    public class demoController : Controller
    {
        IDept d;
        IEmp e;
        public demoController(IDept d1,IEmp e1)
        {//paras will receive class objects through dependency injection
            d = d1;
            e = e1;
       }
        public ActionResult Index()
        {
            ViewBag.dinfo = d.adddept(10, "accts");
            return View();
        }
        public ActionResult index1()
        {
            ViewBag.einfo = e.addemp(1, "raju");
            return View();
        }


    }
}