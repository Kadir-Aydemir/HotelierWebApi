using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebUI.ViewComponents.Default
{
    public class _ServicesPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
