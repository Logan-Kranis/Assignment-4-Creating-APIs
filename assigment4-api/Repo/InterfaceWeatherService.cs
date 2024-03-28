using assigment4_api.entities;

namespace assigment4_api.Repo
{
    public interface InterfaceWeatherService
    {
        Task<List<Weather>> GetWeatherByID(int WeatherID);
    }
}
