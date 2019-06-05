using System.Collections.Generic;
using CopperMouseNetVue.Models;

namespace CopperMouseNetVue.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
