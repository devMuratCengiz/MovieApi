using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult MovieList()
        {
            ViewBag.v1 = "Movie Listing";
            ViewBag.v2 = "Home";
            ViewBag.v1 = "All Movies";
            return View();
        }
    }
}
