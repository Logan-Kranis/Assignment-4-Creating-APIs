using assigment4_api.entities;
//Ahmed Ismail
namespace assigment4_api.Repo
{
    public interface IWeatherService
    {
        public Task<List<Farm>> GetUpdateFarms(int Updatefarms);
    }
}

