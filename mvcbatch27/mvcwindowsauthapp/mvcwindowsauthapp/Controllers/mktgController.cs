using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcwindowsauthapp.Controllers
{
     [Authorize(Users = "peers-pc\\muser1")]
    public class mktgController : Controller
    {
        // GET: mktg
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult sales()
        {
            return View();
        }



    }
}