using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using assigment4_api.Data;
using assigment4_api.entities;
using assigment4_api.Repo;
//Logan Kranis
namespace assigment4_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FarmsController : ControllerBase
    {
        private readonly DBcontextClass _context;
        private readonly InterfaceFarmService _farmService;

        public FarmsController(DBcontextClass context, InterfaceFarmService farmService)
        {
            _context = context;
            _farmService = farmService;
        }

        // GET: api/Farms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Farm>>> GetFarm()
        {
            return await _context.Farm.ToListAsync();
        }

        // GET: api/Farms/5
        [HttpGet("GetFarm/{city}")]
        public async Task<ActionResult<Farm>> GetFarm(string city)
        {
            var result = await _farmService.GetFarmsbyCity(city);

            if (result is not null)
            {
                return result;
            }
            else
            {
                return NotFound();
            }
        }

        // PUT: api/Farms/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost("Put Farm/{id}")]
        //public async Task<IActionResult> PutFarm(int id, Farm farm)
        //{
        //    if (id != farm.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(farm).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!FarmExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Farms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("PostFarm")]
        public async Task<ActionResult<Farm>> PostFarm(Farm farm)
        {
            _context.Farm.Add(farm);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFarm", new { id = farm.Id }, farm);
        }

        // DELETE: api/Farms/5
        [HttpDelete("DeleteFarm/{id}")]
        public async Task<IActionResult> DeleteFarm(int id)
        {
            var farm = await _context.Farm.FindAsync(id);
            if (farm == null)
            {
                return NotFound();
            }

            _context.Farm.Remove(farm);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        
        private bool FarmExists(int id)
        {
           return _context.Farm.Any(e => e.Id == id);
        }
        //Ahmed Ismail 
        // Post: api/Farms/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<int>> UpdateFarm(Farm farm)
        {
            var _farmservice = await _farmService.UpdateFarm(farm);
         return _farmservice;

        }

    }
}
    
    

