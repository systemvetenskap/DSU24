using DSU24.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DSU24.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private void Erik(string message="hej")
        {

        }
        public HomeController(ILogger<HomeController> logger)
        {
            Erik();
            _logger = logger;
        }

        public IActionResult Index()
        {
            // hämta från api
            return View();
        }

        public IActionResult Privacy() //action control
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