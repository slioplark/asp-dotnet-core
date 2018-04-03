using Microsoft.AspNetCore.Mvc;

namespace AspDotNetCore.Localization.Controllers
{
    public class SController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}