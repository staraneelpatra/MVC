using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcopenauthapp.Controllers
{
    [Authorize]
    public class secureController : Controller
    {
        // GET: secure
        public ActionResult tutorials()
        {
            return View();
        }
    }
}