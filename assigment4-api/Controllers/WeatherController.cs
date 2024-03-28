using Microsoft.AspNetCore.Mvc;
using assigment4_api.entities;
using assigment4_api.Repo;
using Microsoft.AspNetCore.Http;

namespace assigment4_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : Controller
    {
        private readonly IWeatherService WeatherService;
        
            public WeatherController(IWeatherService weatherService)
        {
            this.WeatherService = weatherService;

        }
        [HttpGet("Weather/{updatefarms}")]
        public async Task<List<Farm>> GetUpdateFarms(int Updatefarms)
        {
            var updatefarms = await WeatherService.AddHotel(hotel);
            return hotelDetails;
        }







    }
}



namespace NFLWeatherAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoritesController : ControllerBase
    {
        private readonly IFavoriteService favoriteService;

        public FavoritesController(IFavoriteService FavoriteService)
        {
            this.favoriteService = FavoriteService;
        }
        [HttpGet("team/{userid}")]
        public async Task<List<TeamFav>> ShowFavoriteTeam(int userid)
        {
            var favTeam = await favoriteService.ShowFavoriteTeam(userid);
            if (favTeam == null)
            {
                // return NotFound();
            }
            return favTeam;
        }

        [HttpGet("player/{userid}")]
        public async Task<List<PlayerFav>> ShowFavoritePlayer(int userid)
        {
            var favPlayer = await favoriteService.ShowFavoritePlayer(userid);
            if (favPlayer == null)
            {
                // return NotFound();
            }
            return favPlayer;
        }
    }
}