using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel.Models;

namespace ViewModel.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            FacultyModel fobj = new FacultyModel() { Fid = 1, Fname = "Anil" };
            StudentModel sobj = new StudentModel() { Sid = 101, Sname = "Animalking" };
            FSViewModel fsobj = new FSViewModel();
            fsobj.Faculty = fobj;
            fsobj.Student = sobj;
            return View(fsobj);
        }
    }
}