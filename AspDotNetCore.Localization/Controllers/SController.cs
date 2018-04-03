using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace AspDotNetCore.Localization.Controllers
{
    public class SController : Controller
    {
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;

        public SController(IStringLocalizer<SharedResource> sharedLocalizer)
        {
            _sharedLocalizer = sharedLocalizer;
        }

        public IActionResult IndexOfView()
        {
            return View();
        }

        public IActionResult IndexOfController()
        {
            ViewData["Language"] = _sharedLocalizer["Language"];
            ViewData["Translation"] = _sharedLocalizer["Translation"];
            ViewData["One"] = _sharedLocalizer["One"];
            ViewData["Two"] = _sharedLocalizer["Two"];
            ViewData["Three"] = _sharedLocalizer["Three"];
            ViewData["Four"] = _sharedLocalizer["Four"];
            ViewData["Five"] = _sharedLocalizer["Five"];
            ViewData["Six"] = _sharedLocalizer["Six"];
            ViewData["Seven"] = _sharedLocalizer["Seven"];
            ViewData["Eight"] = _sharedLocalizer["Eight"];
            ViewData["Nine"] = _sharedLocalizer["Nine"];
            ViewData["Ten"] = _sharedLocalizer["Ten"];
            return View();
        }
    }
}