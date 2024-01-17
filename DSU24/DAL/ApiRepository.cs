using DSU24.Models;

namespace DSU24.DAL
{
    // konkret klass
    // konkreta klasser kan vi skapa objekt från
    public class ApiRepository : IApiRepository
    {
        public DisplayWeatherForecastViewModel GetForecast()
        {
            // skarpa data
            return null;
        }
        public DisplayWeatherForecastViewModel GetThunder()
        {
            // skarpa data
            return null;
        }
    }

    // konkret klass för mockdata
    public class MockApiRepository : IApiRepository
    {
        public DisplayWeatherForecastViewModel GetForecast()
        {
            // mockdata
            return new DisplayWeatherForecastViewModel(new WeatherForecastDto());
        }

        public DisplayWeatherForecastViewModel GetThunder()
        {
            return new DisplayWeatherForecastViewModel(new WeatherForecastDto());
        }
    }
}
