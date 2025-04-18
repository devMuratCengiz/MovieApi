using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponents.UserLayoutWebUI
{
    public class _UserLayoutWebUINavbar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
