using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using mvcdiapp.repositories;
using mvcdiapp.Models;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
namespace mvcdiapp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            IUnityContainer obj = new UnityContainer();
            obj.RegisterType<IDept, actualdept>();
            obj.RegisterType<IEmp, fakeemp>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(obj));//this will inject registered model class objects to interface vars of controller constructor 





            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
