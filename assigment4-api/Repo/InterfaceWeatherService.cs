using assigment4_api.entities;

namespace assigment4_api.Repo
{
    public interface InterfaceWeatherService
    {
        Task<Weather> GetWeatherByID(int WeatherID);
    }
}
