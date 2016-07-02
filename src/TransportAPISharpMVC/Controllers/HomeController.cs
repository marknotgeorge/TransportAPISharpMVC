using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportAPISharpMVC.Models;

namespace TransportAPISharpMVC.Controllers
{
    public class HomeController : Controller
    {
        private AppKeyConfig _appKeys;

        public HomeController(IOptions<AppKeyConfig> appKeys)
        {
            _appKeys = appKeys.Value;
        }

        public IActionResult Index()
        {
            ViewData["BingMapsAPIKey"] = _appKeys.BingMapsAPIKey;

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}