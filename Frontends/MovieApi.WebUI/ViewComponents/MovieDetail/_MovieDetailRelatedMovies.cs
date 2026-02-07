using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponents.MovieDetail
{
    public class _MovieDetailRelatedMovies : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
