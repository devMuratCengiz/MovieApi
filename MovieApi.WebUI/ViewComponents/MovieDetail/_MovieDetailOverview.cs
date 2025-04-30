using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponents.MovieDetail
{
    public class _MovieDetailOverview : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
