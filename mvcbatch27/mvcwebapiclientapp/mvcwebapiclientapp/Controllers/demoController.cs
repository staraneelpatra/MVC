﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcwebapiclientapp.Controllers
{
    public class demoController : Controller
    {
        // GET: demo
        public ActionResult Index()
        {
            return View();
        }
    }
}