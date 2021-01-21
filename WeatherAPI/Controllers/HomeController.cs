using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WeatherAPI.Models;

namespace WeatherAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _config;

        public HomeController(IConfiguration config)
        {
            _config = config;
        }
        public IActionResult Index()
        {
            var newsApiKey = _config["NewsApi:apiKey"];
            HeadlineModel articles = new HeadlineModel();
            var url = "http://newsapi.org/v2/top-headlines?" +
          "country=us&" +
          "apiKey=" + newsApiKey;

            var json = new WebClient().DownloadString(url);
            articles = JsonConvert.DeserializeObject<HeadlineModel>(json);
            return View(articles);
        }

        public IActionResult About()
        {

            return View();
        }

        [HttpPost]
        public IActionResult About(string query)
        {
            var newsApiKey = _config["NewsApi:apiKey"];
            HeadlineModel articles = new HeadlineModel();
            var url = "http://newsapi.org/v2/everything?q=" + query +
            "&apiKey=" + newsApiKey;

            var json = new WebClient().DownloadString(url);
            articles = JsonConvert.DeserializeObject<HeadlineModel>(json);
            return View(articles);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
