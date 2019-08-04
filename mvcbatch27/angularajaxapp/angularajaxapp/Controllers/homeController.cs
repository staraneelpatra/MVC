using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using angularajaxapp.Models;
namespace angularajaxapp.Controllers
{
    public class homeController : Controller
    {//create dbcontext object
        mvcbatch26Entities obj = new mvcbatch26Entities();
        public JsonResult getprods()
        {
            return Json(obj.products.ToList(), JsonRequestBehavior.AllowGet);
        }









      
        public ActionResult Index()
        {
            return View();
        }
    }
}