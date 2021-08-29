using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpdateWeather.DAL;
using UpdateWeather.Model.Weather;

namespace UpdateWeather.Service.Interface
{
    public interface IWeatherRepository
    {
        Task UpdateWeatherDetailsAsync();
        Task<bool> CreateWeatherAsync(WeatherModel weatherModel);

        Task<List<Weather>> GetAllWeatherAsync();
    }
}
