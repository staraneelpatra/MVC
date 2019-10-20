﻿using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CustomFilters
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            App_Start.FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }
    }
}
