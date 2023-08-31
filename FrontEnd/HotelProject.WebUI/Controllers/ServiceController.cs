using System.Text.Json;
using HotelProject.WebUI.Dtos.ServiceDto;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class ServiceController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public ServiceController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5000/api/Service");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonSerializer.Deserialize<List<ResultServiceDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddService()
        {

            return View();
        }

        // [HttpPost]
        // public async Task<IActionResult> AddService(AddServiceViewModel model)
        // {
        //     var client = _httpClientFactory.CreateClient();
        //     var jsonData = JsonSerializer.Serialize(model);
        //     StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        //     var responseMessage = await client.PostAsync("http://localhost:5000/api/Service", stringContent);
        //     if (responseMessage.IsSuccessStatusCode)
        //     {
        //         return RedirectToAction("Index");
        //     }
        //     return View();
        // }

        // [HttpGet]
        // public async Task<IActionResult> DeleteService(int id)
        // {
        //     var client = _httpClientFactory.CreateClient();
        //     var responseMessage = await client.DeleteAsync($"http://localhost:5000/api/Service/{id}");
        //     if (responseMessage.IsSuccessStatusCode)
        //     {
        //         return RedirectToAction("Index");
        //     }
        //     return View();
        // }

        // [HttpGet]
        // public async Task<IActionResult> UpdateService(int id)
        // {
        //     var client = _httpClientFactory.CreateClient();
        //     var responseMessage = await client.GetAsync($"http://localhost:5000/api/Service/{id}");

        //     if (responseMessage.IsSuccessStatusCode)
        //     {
        //         var jsonData = responseMessage.Content.ReadAsStringAsync();
        //         var value = JsonSerializer.Deserialize<UpdateServiceViewModel>(await jsonData);
        //         Console.WriteLine("xjx");
        //         return View(value);
        //     }
        //     return View();
        // }
        // [HttpPost]
        // public async Task<IActionResult> UpdateService(UpdateServiceViewModel model)
        // {
        //     var client = _httpClientFactory.CreateClient();
        //     var jsonData = JsonSerializer.Serialize(model);
        //     StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        //     var responseMessage = await client.PutAsync("http://localhost:5000/api/Service", stringContent);
        //     if (responseMessage.IsSuccessStatusCode)
        //     {
        //         return RedirectToAction("Index");
        //     }
        //     return View();
        // }

        // [HttpGet]
        // public async Task<IActionResult> DetailService(int id)
        // {
        //     // var client = _httpClientFactory.CreateClient();
        //     // var responseMessage = await client.GetAsync($"http://localhost:5000/api/Service/{id}");

        //     // if (responseMessage.IsSuccessStatusCode)
        //     // {
        //     //     var jsonData = responseMessage.Content.ReadAsStringAsync();
        //     //     var value = JsonSerializer.Deserialize<UpdateServiceViewModel>(await jsonData);
        //     //     Console.WriteLine("xjx");
        //     //     return View(value);
        //     // }
        //     return View();
        // }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}