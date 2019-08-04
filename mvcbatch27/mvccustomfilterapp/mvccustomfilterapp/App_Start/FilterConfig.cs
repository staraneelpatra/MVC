using System.Web;
using System.Web.Mvc;
using mvccustomfilterapp.filters;
namespace mvccustomfilterapp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {//by default HandleError filter is registered as global filter
            filters.Add(new logfilter());//this makes logfilter as global filter,this will be applied to all the actions with in web app
            filters.Add(new HandleErrorAttribute());
        }
    }







}
