using AspDotNetCore.Localization.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetCore.Localization.Controllers
{
    public class MController : Controller
    {
        public IActionResult Index()
        {
            return View(model: new LocalizationViewModel());
        }
    }
}