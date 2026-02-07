using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponents.AdminLayout
{
    public class _AdminLayoutScripts : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
