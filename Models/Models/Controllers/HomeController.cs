using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Models;

namespace Models.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            EmployeeModel em = new EmployeeModel() { EmployeeId = 123, EmployeeName = "Anil Kumar Patra" };
            ViewBag.embag = em;
            return View();
        }

        public ActionResult Index1()
        {
            EmployeeModel em1 = new EmployeeModel();
            em1.EmployeeId = 456;
            em1.EmployeeName = "Satyaranjan Sabat";
            return View(em1);
        }
        public ActionResult Index2()
        {
            //Binded Model with View to get properties in intellisense
            EmployeeModel em1 = new EmployeeModel();
            em1.EmployeeId = 789;
            em1.EmployeeName = "Abhijit Mishra";
            return View(em1);
        }
    }
}