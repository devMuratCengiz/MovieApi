using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponents.UserLayoutWebUI
{
    public class _UserLayoutWebUIScript : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
