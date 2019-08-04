using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcmodelapp.Models;
namespace mvcmodelapp.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {//create model class object
            customermodel cinfo1 = new customermodel();
            cinfo1.custid = "c001";
            cinfo1.custname = "raju";
            ViewBag.info = cinfo1;
            return View();
        }
        public ActionResult index1()
        {
            customermodel cinfo2 = new customermodel { custid = "c002", custname = "ramu" };
            return View(cinfo2);//calling view by returning model object,this object can be referenced with in view using Model keyword
       }









    }
}