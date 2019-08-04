using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
namespace mvccustomfilterapp.filters
{
    public class logfilter:ActionFilterAttribute
    {  
        
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {//para filtercontext will provide user request details[controllername,actionname,.. requested by user]
            string cname = filterContext.RouteData.Values["controller"].ToString();
            string aname = filterContext.RouteData.Values["action"].ToString();
            string info = "controllname:" + cname + " actionname:" + aname + " datetime:" + DateTime.Now.ToString();
            StreamWriter sw = File.AppendText(System.Web.HttpContext.Current.Server.MapPath("/files/userslog.txt"));
            sw.WriteLine(info);//writting user request details into text file
            sw.WriteLine("*************************************");
            sw.Close();
       }
        
  }



}