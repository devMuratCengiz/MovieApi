using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponents.UserLayoutWebUI
{
    public class _UserLayoutWebUIHead : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
