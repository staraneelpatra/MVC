using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcjtableapp.Models;
namespace mvcjtableapp.Controllers
{
    public class demoController : Controller
    {//create dbcontext object
        mvcbatch27Entities obj = new mvcbatch27Entities();
        public ActionResult getstuds(int jtstartindex=0,int jtpagesize=0,string jtsorting=null)
        {//jtstartindex will receive count of recs to be skipped
        //jtpagesize will receive count of recs to be returned
        //jtsorting will receive colname ASC|DESC to return sorted data
            var res = from s in obj.students
                      select s;
            switch(jtsorting)
            {
                case "studid ASC":
                    res = res.OrderBy(ss => ss.studid);
                    break;
                case "studid DESC":
                    res = res.OrderByDescending(ss => ss.studid);
                    break;
                case "studname ASC":
                    res = res.OrderBy(ss => ss.studname);
                    break;
                case "studname DESC":
                    res = res.OrderByDescending(ss => ss.studname);
                    break;
            }
            int c = res.Count();
            res = res.Skip(jtstartindex);
            res = res.Take(jtpagesize);
            return Json(new {Result="OK",Records=res,totalrecordcount=c });
            //result=ok will inform jtable server side exec is successfull
            //records=res will provide recs to jtable for display
            //totalrecordcount will be given to jtable to calculate numb of pages
        }
        //createAction required for jtable to insert rec
        public ActionResult addstudent(student s)
        {//para s will receive student info from jtable
            try
            {
                obj.students.Add(s);
                obj.SaveChanges();
                return Json(new { Result = "OK", Record = s });
            }
            catch(Exception ee)
            {
                return Json(new { Result = "ERROR", Message = "studid already existing" });
            }
        }
        //updateaction for jtable to modify rec
        public ActionResult updatestudent(student s)
        {//para s will recieve modified student info from jtable
            var res = obj.students.Find(s.studid);
            res.studaddr = s.studaddr;
            res.studcity = s.studcity;
            obj.SaveChanges();
            return Json(new { Result = "OK" });
       }
        //deleteaction for jtable to delete student info
        public ActionResult deletestudent(student s)
        {
            var ss = obj.students.Find(s.studid);
            obj.students.Remove(ss);
            obj.SaveChanges();
          //  obj.Entry(s).State = System.Data.Entity.EntityState.Deleted;
            return Json(new { Result = "OK" });
        }
















        // GET: demo
        public ActionResult Index()
        {
            return View();
        }
    }
}