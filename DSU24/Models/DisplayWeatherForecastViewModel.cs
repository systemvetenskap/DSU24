namespace DSU24.Models
{
    public class DisplayWeatherForecastViewModel
    {
        public double Temperature { get; set; }
        public DisplayWeatherForecastViewModel(WeatherForecastDto weatherForecastDto)
        {
            Temperature = -19.5;
        }
    }
}
