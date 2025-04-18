using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponents.UserLayoutWebUI
{
    public class _UserLayoutWebUIPreloader : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
