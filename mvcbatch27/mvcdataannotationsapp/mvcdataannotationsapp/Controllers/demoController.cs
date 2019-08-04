using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcdataannotationsapp.Models;
namespace mvcdataannotationsapp.Controllers
{
    public class demoController : Controller
    {//write action method m1 required for remoteattribute
        public JsonResult m1(int numb)
        {//para name should be same as property name
            bool b;
            if (numb % 2 == 0)
                b = true;//valid
            else
                b = false;//invalid
            return Json(b, JsonRequestBehavior.AllowGet);
            //remoteattribute ajax call will expect json boolean type data
            //json method will convert .net bool type to json boolean type understandable to javascript[ajax call]
        }








        // GET: demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult store(usermodel u)
        {//para u will receive data from index view
            if (u.numb % 2 != 0)
                ModelState.AddModelError("numb", "enter even numb");//this will be considered,if validations are performed on server
            if (ModelState.IsValid)
                //validations are successfull,store userinfo into db table
                return View(u);
            else
                return View("index");
        }







    }
}