﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcpartialviewapp.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult campus()
        {
            return View();
        }
        public ActionResult classrooms()
        {
            return View();
        }
        public ActionResult lab()
        {
            return View();
        }






    }
}