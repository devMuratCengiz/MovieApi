using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponents.AdminLayout
{
    public class _AdminLayoutBreadCrumb: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
