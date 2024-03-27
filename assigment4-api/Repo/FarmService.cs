using assigment4_api.Data;
using assigment4_api.entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
//Logan Kranis
namespace assigment4_api.Repo
{
    public class FarmService : InterfaceFarmService
    {
        private readonly DBcontextClass _dbcontextClass;

        public FarmService(DBcontextClass dbcontextClass) 
        { 
            _dbcontextClass = dbcontextClass;
        }

        public async Task<List<Farm>> GetFarmsbyCity(int cityfarm ) 
        { 
            var param = new SqlParameter("@city", cityfarm );
            var cityfdetails = await Task.Run(() => _dbcontextClass.Farm.FromSqlRaw("exec SelectFarmsByCity @city",param).ToListAsync());
            return cityfdetails;
        }
    }
}
