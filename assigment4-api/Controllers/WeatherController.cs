using Microsoft.AspNetCore.Mvc;

namespace assigment4_api.Controllers
{
    public class WeatherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
