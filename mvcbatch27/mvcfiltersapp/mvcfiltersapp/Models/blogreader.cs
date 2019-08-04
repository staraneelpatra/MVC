using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace mvcfiltersapp.Models
{
    public class blogreader
    {
        public string name { set; get; }
        [AllowHtml]
        public string comment { set; get; }
    }
}