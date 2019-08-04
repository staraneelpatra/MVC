using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcwindowsauthapp.Controllers
{
     [Authorize(Users = "peers-pc\\huser1")]
    public class hrdController : Controller
    {
        // GET: hrd
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult addemp()
        {
            return View();
        }
    }
}