using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvccodefirstapp.Models;
namespace mvccodefirstapp.Controllers
{
    public class companyController : Controller
    {//create dbcontext object
        companyDbContext obj = new companyDbContext();








        // GET: company
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult adddept()
        {
            return View();
        }
        [HttpPost]
        public ActionResult adddept(dept d)
        {//para d will receive dept info from adddept view
            obj.depts.Add(d);//adding rec into dbset
            obj.SaveChanges();//it will apply dbset changes to db table[inserting rec into db table]
            return View("index");
        }
        public ActionResult displaydepts()
        {
            List<dept> deptsinfo = obj.depts.ToList();//it will return table recs in the form of list collection
            return View(deptsinfo);
        }
        public ActionResult editdept(int id)
        {//para id will receive deptno from edit hyperlink of displaydepts view
            var dinfo = obj.depts.Find(id);
            //or linq
            //var dinfo=from d in obj.depts where d.deptno=id select d;
            return View(dinfo);
        }
        [HttpPost]
        public ActionResult editdept(dept d)
        {//para d will receive modified dept[dname] info,apply this changes to dbset then save to db table
            var dinfo = obj.depts.Find(d.deptno);
            dinfo.dname = d.dname;
            obj.SaveChanges();
            return View("displaydepts", obj.depts.ToList());//calling view by sending depts info including modified dept
       }
        public ActionResult deletedept(int id)
        {
            var dinfo = obj.depts.Find(id);
            obj.depts.Remove(dinfo);//it will mark rec for deletion with in dbset
            obj.SaveChanges();//it will apply dbset marked rec for deletion with in db table
            return View("displaydepts", obj.depts.ToList());
        }
        public ActionResult addemp()
        {
            List<SelectListItem> ds = new List<SelectListItem>();
            foreach(var d in obj.depts)
            {
                ds.Add(new SelectListItem { Text = d.dname, Value = d.deptno.ToString() });
            }
            ViewBag.depts = ds;
            return View();
        }
        [HttpPost]
        public ActionResult addemp(emp e)
        {
            obj.emps.Add(e);
            obj.SaveChanges();
            return View("index");
        }

















    }
}