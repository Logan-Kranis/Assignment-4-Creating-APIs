using assigment4_api.entities;
using Microsoft.Identity.Client;
//Logan Kranis
namespace assigment4_api.Repo
{
    public interface InterfaceFarmService
    {
        public Task<List<Farm>> GetFarmsbyCity(int cityfarm);

        //Ahmed Ismail 
        public Task<List<Farm>> GetUpdateFarms(int updatefarm);
        public Task<List<Farm>> DeleteFarms(int deletefarm);
    }
}
