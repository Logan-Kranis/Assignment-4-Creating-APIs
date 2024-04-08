using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using assigment4_api.Data;
using assigment4_api.entities;

namespace assigment4_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly DBcontextClass _context;

        public WeatherController(DBcontextClass context)
        {
            _context = context;
        }

        // GET: api/Weathers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Weather>>> GetWeather()
        {
            return await _context.Weather.ToListAsync();
        }

        // GET: api/Weathers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Weather>> GetWeather(int id)
        {
            var weather = await _context.Weather.FindAsync(id);

            if (weather == null)
            {
                return NotFound();
            }

            return weather;
        }

        

        private bool WeatherExists(int id)
        {
            return _context.Weather.Any(e => e.Id == id);
        }
    }
}
