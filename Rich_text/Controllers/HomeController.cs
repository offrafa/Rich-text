using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rich_text.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Rich_text.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
