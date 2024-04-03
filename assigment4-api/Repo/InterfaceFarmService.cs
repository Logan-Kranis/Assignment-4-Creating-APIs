using assigment4_api.entities;
//Logan Kranis & Ahmed Ismail
namespace assigment4_api.Repo
{
    public interface InterfaceFarmService
    {
        public Task<int> DeleteFarms(Farm farm);
        public Task<Farm> GetFarmsbyCity(string city);
        public Task<int> UpdateFarm(Farm farm);
    }


    
     

}
