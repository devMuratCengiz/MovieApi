using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponents.UserLayoutWebUI
{
    public class _UserLayoutWebUIHero:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
