using assigment4_api.Data;
using assigment4_api.entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
//Logan Kranis
namespace assigment4_api.Repo
{
    public class WeatherService : InterfaceWeatherService
    {
        private readonly IConfiguration _configuration;

        private readonly DBcontextClass _dbcontextClass;
        public WeatherService(DBcontextClass dbcontextClass, IConfiguration configuration)
        {
            _dbcontextClass = dbcontextClass;
            _configuration = configuration;
        }
        public async Task<Weather> GetWeatherByID(int WeatherID)
        {
            Weather weather = new Weather();

            using (SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("GetWeatherByID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@WEATHER_ID", WeatherID));
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        weather.Temperature = (decimal)rdr["temperature"];
                        weather.Pressure = (decimal)rdr["pressure"];
                        weather.Humidity = (decimal)rdr["humidity"];
                        weather.Precipitation = (decimal)rdr["precipitation"];
                        weather.Wind_Speed = (decimal)rdr["wind_speed"];
                        weather.Id = (int)rdr["id"];
                        weather.Date = (DateTime)rdr["date"];


                    }
                }
            }




         return weather;
        }
    }
}
