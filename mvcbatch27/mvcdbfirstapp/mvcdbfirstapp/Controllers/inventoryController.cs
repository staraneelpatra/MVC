using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcdbfirstapp.Models;
namespace mvcdbfirstapp.Controllers
{
    public class inventoryController : Controller
    {//create dbcontext object
        mvcbatch27Entities obj = new mvcbatch27Entities();
   public ActionResult addproduct()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult addproduct(product p)
   {
       obj.addproduct(p.prodid, p.prodname, p.prodprice, p.cateid);//calling stored proc using dbcontext to insert rec
       return View("index");
   }
        public ActionResult display()
        {
            obj.Configuration.AutoDetectChangesEnabled = false;
            return PartialView(obj.products.ToList());
        }







        // GET: inventory
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult index1()
        {
            obj.Configuration.LazyLoadingEnabled = false;
            return View(obj.categories.Include("products").ToList());
        }









    }
}