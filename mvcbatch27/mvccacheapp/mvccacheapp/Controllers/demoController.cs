using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvccacheapp.Models;
namespace mvccacheapp.Controllers
{
    public class demoController : Controller
    {//create dbcontext object
        mvcbatch27Entities obj = new mvcbatch27Entities();
        [OutputCache(Duration=300)]
        public ActionResult Index()
        {
            return View(obj.products.ToList());
        }
        public ActionResult search()
        {
            List<SelectListItem> cs = new List<SelectListItem>();
            cs.Add(new SelectListItem { Text = "select category-" });
            foreach(var c in obj.categories)
            {
                cs.Add(new SelectListItem { Text = c.catename, Value = c.cateid });
            }
            ViewBag.cinfo = cs;
            return View();
        }
        [OutputCache(Duration=300,VaryByParam="cid")]
        public ActionResult searchresult(string cid)
        {
            var res = obj.products.Where(p => p.cateid == cid);
            //select * from product where cateid=cid
            ViewBag.cateid = cid;
            //System.Web.Caching.Cache cc = new System.Web.Caching.Cache();
            
            return PartialView(res);
        }














    }
}