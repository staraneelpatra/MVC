using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcformsauthapp.Models;
namespace mvcformsauthapp.Controllers
{
    public class homeController : Controller
    {//create dbcontext object
        mvcbatch27Entities obj = new mvcbatch27Entities();
        public ActionResult register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult register(usersinfo u)
        {
            obj.usersinfoes.Add(u);
            obj.SaveChanges();
            return View("feedback");
        }
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult login(usersinfo u)
        {
            bool b=false;
            string v = Request.Form["c1"];//it returns on for checked
            if (v == "on")
                //stay signed in checkbox is selected
                b = true;
            var res = obj.usersinfoes.Where(u1 => u1.username == u.username && u1.password == u.password);
            //select .. from usersinfo where username=u.username and password==u.password
            if(res.Count()==0)
            {
                ViewBag.msg = "invalid name or pasword";
                return View("login");
            }
            else
            {//valid user acct
                TempData["name"] = u.username;
    System.Web.Security.FormsAuthentication.SetAuthCookie(u.username, b);
    return RedirectToAction("welcome", "secure");
            }
        }



















        // GET: home
        public ActionResult Index()
        {
            return View();
        }
    }
}