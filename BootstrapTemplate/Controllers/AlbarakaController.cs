﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace BootstrapTemplate.Controllers
{
    // diffrent Idea of navigation
    [AllowAnonymous]
    public class AlbarakaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Recon()
        {

            return View();
        }
    }
}