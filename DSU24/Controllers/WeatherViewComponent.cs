using DSU24.Infrastructure;
using DSU24.Models;
using Microsoft.AspNetCore.Mvc;

namespace DSU24.Controllers
{
    public class WeatherViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string apiUrl = "https://opendata-download-metfcst.smhi.se/api/category/pmp3g/version/2/geotype/point/lon/14.651646/lat/63.177673/data.json";
            var response = await ApiEngine.Fetch<WeatherForecastDto>(apiUrl); // hämta från api
            var model = new DisplayWeatherForecastViewModel(response.Data);
            return View(model);
        }
    }
}
