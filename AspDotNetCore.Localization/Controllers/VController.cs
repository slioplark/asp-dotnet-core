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