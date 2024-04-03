using assigment4_api.entities;
//Logan Kranis
namespace assigment4_api.Repo
{
    public interface InterfaceFarmService
    {
        public Task<Farm> DeleteFarms(Farm farm);
        public Task<Farm> GetFarmsbyCity(string city);
        public Task<Farm> UpdateFarm(Farm farm);
    }


    
     

}
