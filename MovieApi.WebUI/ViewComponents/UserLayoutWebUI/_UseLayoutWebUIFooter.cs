using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponents.UserLayoutWebUI
{
    public class _UseLayoutWebUIFooter : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
