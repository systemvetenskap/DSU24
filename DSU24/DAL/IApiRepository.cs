using DSU24.Models;

namespace DSU24.DAL
{
    public interface IApiRepository
    {
        DisplayWeatherForecastViewModel GetForecast();
        DisplayWeatherForecastViewModel GetThunder();
    }
}