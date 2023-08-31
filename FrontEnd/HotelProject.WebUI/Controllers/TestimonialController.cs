using System.Text;
using System.Text.Json;
using HotelProject.WebUI.Models.Testimonial;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public TestimonialController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5000/api/Testimonial");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonSerializer.Deserialize<List<TestimonialViewModel>>(jsonData);
                return View(values);
            }

            return View();
        }

        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTestimonial(AddTestimonialViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonSerializer.Serialize(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:5000/api/Testimonial", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:5000/api/Testimonial/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateTestimonial(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5000/api/Testimonial/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = responseMessage.Content.ReadAsStringAsync();
                var value = JsonSerializer.Deserialize<UpdateTestimonialViewModel>(await jsonData);
                Console.WriteLine("xjx");
                return View(value);
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonSerializer.Serialize(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:5000/api/Testimonial", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}