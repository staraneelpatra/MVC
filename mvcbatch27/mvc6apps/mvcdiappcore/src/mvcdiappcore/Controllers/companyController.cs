using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvcdiappcore.Models;
// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace mvcdiappcore.Controllers
{
    public class companyController : Controller
    {
        IEmp e;
        // GET: /<controller>/
        public companyController(IEmp e1)
        {
            e = e1;
        }
        public IActionResult Index()
        {
            e.setemp(1, "raju");
            ViewBag.info = e.displayemp();
            return View();
        }
    }
}
