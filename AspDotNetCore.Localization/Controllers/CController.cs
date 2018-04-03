using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace AspDotNetCore.Localization.Controllers
{
    public class CController : Controller
    {
        private readonly IStringLocalizer<CController> _localizer;

        public CController(IStringLocalizer<CController> localizer)
        {
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            ViewData["Language"] = _localizer["Language"];
            ViewData["Translation"] = _localizer["Translation"];
            ViewData["One"] = _localizer["One"];
            ViewData["Two"] = _localizer["Two"];
            ViewData["Three"] = _localizer["Three"];
            ViewData["Four"] = _localizer["Four"];
            ViewData["Five"] = _localizer["Five"];
            ViewData["Six"] = _localizer["Six"];
            ViewData["Seven"] = _localizer["Seven"];
            ViewData["Eight"] = _localizer["Eight"];
            ViewData["Nine"] = _localizer["Nine"];
            ViewData["Ten"] = _localizer["Ten"];
            return View();
        }
    }
}