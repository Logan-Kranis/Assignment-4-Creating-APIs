using assigment4_api.Data;
using assigment4_api.entities;
using assigment4_api.Repo;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
//Logan Kranis
namespace assigment4_api.Repo
{
    public class FarmService : InterfaceFarmService
    {
        private readonly DBcontextClass _dbcontextClass;
        private readonly IConfiguration _configuration;

        public FarmService(DBcontextClass dbcontextClass, IConfiguration configuration) 
        { 
            _dbcontextClass = dbcontextClass;
            _configuration = configuration;
        }

        public async Task<List<Farm>> GetFarmsbyCity(int cityfarm ) 
        { 
            var param = new SqlParameter("@city", cityfarm );
            var cityfdetails = await Task.Run(() => _dbcontextClass.Farm.FromSqlRaw("exec SelectFarmsByCity @city",param).ToListAsync());
            return cityfdetails;
        }
        //Ahmed Ismail
        public async Task<List<Farm>> GetUpdateFarms(int Updatefarms)
        {

            var param = new SqlParameter("@FarmID", Updatefarms);
            var Updatefarmsdetails = await Task.Run(() => _dbcontextClass.Farm.FromSqlRaw("exec SelectUpdateFarm @FarmID ", param).ToListAsync());
            return Updatefarmsdetails;

        }
        public async Task<List<Farm>> DeleteFarms(int DeleteFarms)
        {
            var param = new SqlParameter("@FarmID", DeleteFarms);
            var Deletefarms = await Task.Run(() => _dbcontextClass.Farm.FromSqlRaw("exec SelectDeleteFarm @FarmID ", param). ToListAsync());
            return Deletefarms;
        }

    }


}



    


