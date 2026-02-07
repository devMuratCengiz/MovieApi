using Microsoft.AspNetCore.Mvc;
using MovieApi.Dto.Dtos.AdminDtos;
using Newtonsoft.Json;
using System.Text;

namespace MovieApi.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController(IHttpClientFactory _httpClientFactory) : Controller
    {
        public async Task<IActionResult> CategoryList()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7221/api/Categories");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<AdminResultCategoryDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(AdminCreateCategoryDto adminCreateCategoryDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(adminCreateCategoryDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7221/api/Categories", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(CategoryList));
            }
            return View();
        }

        public async Task<IActionResult> DeleteCategory(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.DeleteAsync("https://localhost:7221/api/Categories?id=" + id);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(CategoryList));
            }
            return View();
        }
    }
}
