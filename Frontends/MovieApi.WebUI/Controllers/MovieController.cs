using Microsoft.AspNetCore.Mvc;
using MovieApi.Dto.Dtos.MovieDtos;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace MovieApi.WebUI.Controllers
{
    public class MovieController(IHttpClientFactory _httpClientFactory) : Controller
    {
        public async Task<IActionResult> MovieList()
        {
            ViewBag.v1 = "Film Listesi";
            ViewBag.v2 = "Anasayfa";
            ViewBag.v3 = "Tüm Filmler";

            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7221/api/Movies");

            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultMovieDto>>(jsonData);
                return View(values);
            }

            return View();
        }

        public async Task<IActionResult> MovieDetail(int id)
        {
            return View();
        }
    }
}
