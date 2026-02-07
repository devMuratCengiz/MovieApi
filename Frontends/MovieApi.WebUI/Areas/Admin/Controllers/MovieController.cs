using Microsoft.AspNetCore.Mvc;
using MovieApi.Dto.Dtos.AdminDtos;
using Newtonsoft.Json;
using System.Text;

namespace MovieApi.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MovieController(IHttpClientFactory _httpClientFactory) : Controller
    {
        public async Task<IActionResult> MovieList()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7221/api/Movies");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync(); 
                var values = JsonConvert.DeserializeObject<List<AdminResultMovieDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public IActionResult CreateMovie()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie(AdminCreateMovieDto adminCreateMovieDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(adminCreateMovieDto);
            StringContent content = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var response = await client.PostAsync("https://localhost:7221/api/Movies", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(MovieList));
            }
            return View();
        } 
    }
}
