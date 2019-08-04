using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvcefapp.Models;
// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace mvcefapp.Controllers
{
    public class companyController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            companyDbContext obj = new Models.companyDbContext();
            obj.emps.Add(new Models.emp {empno=1,ename="raju" });
            obj.SaveChanges();
            return View();
        }
    }
}
