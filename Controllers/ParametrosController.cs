﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TesteMVC5.Controllers
{
    public class ParametrosController : Controller
    {
        public ActionResult Index(int id)
        {
            return View();
        }
    }
}