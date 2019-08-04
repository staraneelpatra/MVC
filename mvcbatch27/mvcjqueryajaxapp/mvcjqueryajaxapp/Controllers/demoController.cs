using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using mvcjqueryajaxapp.Models;
namespace mvcjqueryajaxapp.Controllers
{
    public class demoController : Controller
    {//create dbcontext object
        mvcbatch27Entities obj = new mvcbatch27Entities();
        public ActionResult index1()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem { Text = "-select category-" });
            foreach(var c in obj.categories)
            {
                items.Add(new SelectListItem { Text = c.catename, Value = c.cateid });
            }
            ViewBag.cateinfo = items;
            return View();
          }
        public ActionResult getprods(string cid)
        {//para cid will receive cateid from index1 view ajax call
            var res = from p in obj.products
                      where p.cateid == cid
                      select new { p.prodid, p.prodname };
            //ado.net ef
            //var res=obj.products.where(p=>p.cateid==cid)
            return Json(res.ToList(), JsonRequestBehavior.AllowGet);
       }

        public ActionResult index2()
        {
            return View();
        }
        public ActionResult getprods1(string s)
        {
            var res = from p in obj.products
                      where p.prodname.StartsWith(s)
                      select new { p.prodid, p.prodname };
            return Json(res.ToList(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult details(string id)
        {//para id will receive prodid from index2 view hyperlink more..
            var res = obj.products.Find(id);
            return View(res);
       }














        public string getnews()
        {
            var doc = XElement.Load(Server.MapPath("/files/news.xml"));//this will load xml file from harddisk memory into RAM
            string s = doc.Element("msg").Value;//it returns msg xml tag content
            return (s);//returning news info to an ajax call[success function]
        }






        // GET: demo
        public ActionResult Index()
        {
            return View();
        }
    }
}