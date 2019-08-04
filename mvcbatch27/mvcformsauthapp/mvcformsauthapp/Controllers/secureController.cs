using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcformsauthapp.Controllers
{
    [Authorize]
    public class secureController : Controller
    {
        // GET: secure
        public ActionResult welcome()
        {
            return View();
        }
        public ActionResult tutorials()
        {
            return View();
        }
        public ActionResult books()
        {
            return View();
        }
        public ActionResult close()
        {
            System.Web.Security.FormsAuthentication.SignOut();//removing securityticket from client system
            return View();
       }








    }
}