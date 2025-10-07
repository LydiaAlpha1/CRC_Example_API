using CRC_Example_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace CRC_Example_MVC.Controllers
{
    public class ProductsController1 : Controller
    {
        private string baseUrl = "https://localhost:7245/";

        public async Task<IActionResult> Index()
        {
            List<Product> products = new List<Product>();
            
            using (var _httpClient = new HttpClient())
            {
                _httpClient.BaseAddress = new Uri(baseUrl + "api/Products/");
                _httpClient.DefaultRequestHeaders.Accept.Clear();
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage getData = await _httpClient.GetAsync("");

                if (getData.IsSuccessStatusCode)
                {
                    string result = getData.Content.ReadAsStringAsync().Result;
                    products = JsonConvert.DeserializeObject<List<Product>>(result);
                }
                else
                {
                    return View("Error Page");
                }
            }
            return View(products);
        }

        


    }

}
