using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace mvcrouteurlapp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "demo", action = "Index", id = UrlParameter.Optional }
            );//default route url,changing home to demo as default controller
            routes.MapRoute(name: "myroute", url: "{controller}/{action}/{month}/{year}", defaults: new { }, constraints: new { month = "[1-9]|1[012]", year = "\\d{4}" });//custom routeurl







        }
    }
}
