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
        }

        public async Task<List<Farm>> GetUpdateFarms(int Updatefarms)
        {
            var param = new SqlParameter("@FarmID", Updatefarms);
            var Updatefarmsdetails = await Task.Run(() => _dbcontextClass.Farm.FromSqlRaw("exec SelectUpdateFarm @FarmID ", param).ToListAsync());
            return Updatefarmsdetails;
        }


    }
}
