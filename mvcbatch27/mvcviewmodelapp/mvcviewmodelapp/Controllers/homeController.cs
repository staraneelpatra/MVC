using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcviewmodelapp.Models;
namespace mvcviewmodelapp.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            facultymodel finfo = new facultymodel { fid = "f001", fname = "rlp" };
            studentmodel sinfo = new studentmodel { sid = "s001", sname = "raju" };
            //create viewmodel class to group facultymodel and studentmodel objects
            fsviewmodel obj = new fsviewmodel();
            obj.facultyinfo = finfo;
            obj.studentinfo = sinfo;
            return View(obj);
        }







    }





}