using System.Web.Mvc;
using System.Web.Routing;

namespace RoutingMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //    name: "Myroute",
            //    url: "{controller}/{action}/{name}/{cc}",
            //    defaults: new { controller = "Home", action = "BIKE", name = UrlParameter.Optional, cc = UrlParameter.Optional }
            //);
        }
    }
}
