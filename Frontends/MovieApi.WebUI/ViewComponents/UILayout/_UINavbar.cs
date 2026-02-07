using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponents.UILayout
{
    public class _UINavbar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
