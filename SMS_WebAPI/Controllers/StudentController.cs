﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMS_WebAPI.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}