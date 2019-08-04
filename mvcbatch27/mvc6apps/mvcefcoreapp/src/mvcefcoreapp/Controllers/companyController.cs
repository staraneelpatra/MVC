using Microsoft.AspNetCore.Mvc;
using mvcefcoreapp.Models;
using Microsoft.Extensions.Configuration;
// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace mvcefcoreapp.Controllers
{
    public class companyController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ConfigurationBuilder c = new ConfigurationBuilder();
            // ViewBag.info = c.Properties["ConnectionStrings"].ToString();

            companyDbContext obj = new Models.companyDbContext();
            emp e = new Models.emp { empno = 1, ename = "xyz" };
            obj.emps.Add(e);
            obj.SaveChanges();
            return View();
        }
    }
}
