using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvccookiesapp.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            if(Request.Cookies["lvd"]==null)
            {
                ViewBag.msg = "this is first visit to website";
                Response.Cookies["lvd"].Value = DateTime.Now.ToString();
                Response.Cookies["lvd"].Expires = DateTime.Now.AddDays(2);
           }
            else
            {
                ViewBag.msg = "your last visit to website:" + Request.Cookies["lvd"].Value;
                Response.Cookies["lvd"].Value = DateTime.Now.ToString();
                Response.Cookies["lvd"].Expires = DateTime.Now.AddDays(2);
            }
            return View();
        }












    }
}