﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASZWebAppV02.Controllers
{
    public class RegenmessungController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}