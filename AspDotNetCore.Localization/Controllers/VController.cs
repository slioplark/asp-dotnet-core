using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetCore.Localization.Controllers
{
    public class VController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}