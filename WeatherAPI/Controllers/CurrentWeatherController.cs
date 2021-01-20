using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WeatherAPI.Models;
using static WeatherAPI.Models.CurrentWeatherModel;

namespace WeatherAPI.Controllers
{
    public class CurrentWeatherController : Controller
    {
        public async Task<IActionResult> Index()
        {
            CurrentWeatherModel WeatherInfo = new CurrentWeatherModel();
            string Baseurl = "https://localhost:44319/";
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("x-rapidapi-key", "...");
                client.DefaultRequestHeaders.Add("x-rapidapi-host", "weatherbit-v1-mashape.p.rapidapi.com");

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("https://weatherbit-v1-mashape.p.rapidapi.com/current?city=Independence,MO&country=US&units=i");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var WeatherResponse = Res.Content.ReadAsStringAsync().Result;
                
                    //Deserializing the response recieved from web api and storing into the weather Model
               
                    WeatherInfo = JsonConvert.DeserializeObject<CurrentWeatherModel>(WeatherResponse);

                }
                //returning the employee list to view  
                return View(WeatherInfo);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Index(string CityName)
        {
            CurrentWeatherModel WeatherInfo = new CurrentWeatherModel();
            string Baseurl = "https://localhost:44319/";
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("x-rapidapi-key", "1cea7965f6mshe85b862d442ea49p135f78jsne09da033f7b4");
                client.DefaultRequestHeaders.Add("x-rapidapi-host", "weatherbit-v1-mashape.p.rapidapi.com");

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("https://weatherbit-v1-mashape.p.rapidapi.com/current?city=" + CityName + "&country=US&units=i");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var WeatherResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the weather Model

                    WeatherInfo = JsonConvert.DeserializeObject<CurrentWeatherModel>(WeatherResponse);

                }
            }
                return View(WeatherInfo);
        }
    }
}
