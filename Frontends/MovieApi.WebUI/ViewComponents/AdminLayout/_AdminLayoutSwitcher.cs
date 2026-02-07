using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponents.AdminLayout
{
    public class _AdminLayoutSwitcher : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
