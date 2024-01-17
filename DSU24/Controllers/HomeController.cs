using DSU24.DAL;
using DSU24.Infrastructure;
using DSU24.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DSU24.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApiRepository _repo;
        private readonly ILogger<HomeController> _logger;
        private void Erik(string message="hej")
        {

        }
        public HomeController(ILogger<HomeController> logger, IApiRepository apiRepository)
        {
            _repo = apiRepository;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var model = _repo.GetThunder();
            //string apiUrl = "https://opendata-download-metfcst.smhi.se/api/category/pmp3g/version/2/geotype/point/lon/14.651646/lat/63.177673/data.json";
            //var response =await ApiEngine.Fetch<WeatherForecastDto>(apiUrl); // hämta från api
            //var model = new DisplayWeatherForecastViewModel(response.Data);
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