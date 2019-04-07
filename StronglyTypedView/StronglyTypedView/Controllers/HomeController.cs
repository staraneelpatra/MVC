using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StronglyTypedView.Models;

namespace StronglyTypedView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<StudentModel> stud = new List<StudentModel>();
            stud.Add(new StudentModel() { StudentId = 1, StudentName = "Virat", Marks = 100 });
            stud.Add(new StudentModel() { StudentName = "Suresh", Marks = 79, StudentId = 2 });
            stud.Add(new StudentModel() { Marks = 89, StudentId = 3, StudentName = "Bhubaneswar" });
            return View(stud);
        }
    }
}