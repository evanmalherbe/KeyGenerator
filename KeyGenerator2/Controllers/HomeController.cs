using KeyGenerator2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography;

namespace KeyGenerator2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
          return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create()
        {
          // Generates a 512-bit (64-byte) key
			    byte[] keyBytes = new byte[64]; 
			    using (var rng = RandomNumberGenerator.Create())
			    {
					    rng.GetBytes(keyBytes);
			    }

			    // Convert the byte array to a Base64 string for configuration use
			    string base64Key = Convert.ToBase64String(keyBytes);
          ViewBag.Key = base64Key;
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
