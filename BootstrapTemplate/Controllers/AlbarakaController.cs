using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapTemplate.Controllers
{
    // diffrent Idea of navigation
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