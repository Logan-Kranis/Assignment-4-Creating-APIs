using assigment4_api.Data;
using assigment4_api.entities;
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

        public object Returnfarm { get; private set; }

        

        public async Task<Farm> GetFarmsbyCity(string city)

        {
            Farm farm = new Farm();

            using (SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SelectFarmsByCity", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@city", city));
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        farm.Address = rdr["address"].ToString();
                        farm.ZipCode = rdr["zipcode"].ToString();
                        farm.City = rdr["city"].ToString();
                        farm.State = rdr["state"].ToString();
                        farm.Name = rdr["name"].ToString();
                        farm.Id = (int)rdr["Id"];
                        farm.Latitude = (decimal)rdr["Latitude"];
                        farm.Longitude = (decimal)rdr["Longitude"];
                    }
                }
            }

            return farm;
        }

        //Ahmed Ismail
        public async Task<int> UpdateFarm(Farm farm)

        {
            var farmName = new SqlParameter("@FarmName", farm.Name);
            var farmAddress = new SqlParameter("@FarmAddress", farm.Address);
            var farmCity = new SqlParameter("@FarmCity", farm.City);
            var farmZipCode = new SqlParameter("@FarmZipcode",farm.ZipCode);
            var farmState = new SqlParameter("@FarmState", farm.State);
            var farmID = new SqlParameter("@Id", farm.Id);
            var farmDetails = await Task.Run(() => _dbcontextClass.Database.ExecuteSqlRaw("exec UpdateFarm @FarmName,@FarmAddress,@FarmCity,@FarmZipcode,@FarmState,@Id", farmName, farmAddress, farmCity, farmZipCode, farmState, farmID));
            return farmDetails;
        }
        public async Task<int> DeleteFarms(Farm farm)
        {
            var FarmID = new SqlParameter("@Id",farm.Id);
            var farmDetails = await Task.Run(() => _dbcontextClass.Database.ExecuteSqlRaw("exec DeleteFarm @Id", FarmID));
            return farmDetails;
         }

        }
    }
