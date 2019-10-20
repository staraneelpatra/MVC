using System;
using System.Web.Mvc;

namespace CustomFilters
{
    public class CustomLogFilterAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }
    }
}
