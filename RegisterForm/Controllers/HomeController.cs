using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using RegisterForm.Models;
using System.Diagnostics;

namespace RegisterForm.Controllers
{[OutputCache(Duration =20)]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            int a = 10;
            int b = 0;
            int c = a % b;
           
            return View();
        }
        public IActionResult GetDate()
        {
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
