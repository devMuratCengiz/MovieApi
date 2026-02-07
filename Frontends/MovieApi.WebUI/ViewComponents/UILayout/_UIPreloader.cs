using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponents.UILayout
{
    public class _UIPreloader : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
