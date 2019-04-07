using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTMLHelperControls.Models;

namespace HTMLHelperControls.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Save(FormCollection f)
        {
            Storemodel sm = new Storemodel();
            sm.Name = f["un"];
            sm.Gender = f["r1"];

            return View(sm);
        }
    }
}