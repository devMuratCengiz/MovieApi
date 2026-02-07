using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponents.AdminLayout
{
    public class _AdminLayoutHead: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
