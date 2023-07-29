using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult _AdminLayout()
        {
            return View();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult PreloaderPartial()
        {
            return PartialView();
        }
    }
}
