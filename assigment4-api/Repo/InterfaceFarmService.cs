using assigment4_api.entities;
//Logan Kranis
namespace assigment4_api.Repo
{
    public interface InterfaceFarmService
    {
        public Task<Farm> GetFarmsbyCity(string city);
    }
}
