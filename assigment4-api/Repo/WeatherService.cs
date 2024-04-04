using assigment4_api.Data;
using assigment4_api.entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
//Ahmed Ismail
namespace assigment4_api.Repo
{
    public class WeatherService : IWeatherService
    {
        private readonly DBcontextClass _dbcontextClass;
        public WeatherService(DBcontextClass dbcontextClass)
        {
            _dbcontextClass = dbcontextClass;
            _configuration = configuration;
        }
        public async Task<List<Weather>> GetWeatherByID(int WeatherID)
        {
            var param = new SqlParameter("@WEATHER_ID", WeatherID);
            var WeatherIDdetails = await Task.Run(() => _dbcontextClass.Weather.FromSqlRaw("exec GetWeatherByID @WEATHER_ID", param).ToListAsync());
            return WeatherIDdetails;
        }


    }
}
