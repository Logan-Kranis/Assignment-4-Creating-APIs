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
    }
}
