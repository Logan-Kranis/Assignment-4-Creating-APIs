using assigment4_api.Data;
using assigment4_api.entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
//Logan Kranis
namespace assigment4_api.Repo
{
    public class WeatherService : InterfaceWeatherService
    {
        private readonly DBcontextClass _dbcontextClass;
        public WeatherService(DBcontextClass dbcontextClass)
        {
            _dbcontextClass = dbcontextClass;
        }
        public async Task<List<Weather>> GetWeatherByID(int WeatherID)
        {
            var param = new SqlParameter("@WEATHER_ID", WeatherID);
            var WeatherIDdetails = await Task.Run(() => _dbcontextClass.Weather.FromSqlRaw("exec GetWeatherByID @WEATHER_ID", param).ToListAsync());
            return WeatherIDdetails;
        }
    }
}
