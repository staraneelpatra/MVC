using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using mvcdiapp6.Models;
// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace mvcdiapp6.Controllers
{
    public class demoController : Controller
    {
        IEmployee e;
        public demoController(IEmployee e1)
        {
            e = e1;
        }
       public IActionResult Index()
        {
            ViewBag.info = e.addemp(1, "raju");
            return View();
        }
    }







}
