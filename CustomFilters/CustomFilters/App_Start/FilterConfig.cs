using System;
using System.Web.Mvc;

namespace CustomFilters
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CustomLogFilterAttribute());
        }
    }
}
