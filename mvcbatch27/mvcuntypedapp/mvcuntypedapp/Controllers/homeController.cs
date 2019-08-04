using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcuntypedapp.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult store(FormCollection f)
        {//para f will receive helper controls data from index view
            string s = "";
            if (f["c1"] != "false")
                //boarding is selected
                s = "boarding<br>";
            if (f["c2"] != "false")
                //wifi is selected
                s = s + "wifi";
            //assign user submitted info to customermodel object
            Models.customermodel c = new Models.customermodel();
            c.custname = f["txtcustname"];
            c.roomtype = f["r1"];//it provides user selected radiobutton value[delux|ordinary]
            c.amenities = s;
            return View(c);
        }






    }
}