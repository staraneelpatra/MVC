using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvcdiappcore.Models;
// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace mvcdiappcore.Controllers
{
    public class demoController : Controller
    {
        IEmp e;
        // GET: /<controller>/
        public demoController(IEmp e1)
        {
            e = e1;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            e.setempno(10);
            ViewBag.info = e.displayemp();
            return View();
        }
    }
}
