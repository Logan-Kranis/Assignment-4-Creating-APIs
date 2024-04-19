using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace SmartCropfrontEnd.Pages
{
    public class UpdateFarmModel : PageModel
    {
        private readonly IConfiguration _configuration;

        public UpdateFarmModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPostAsync(int farmId, string address, string zipcode, string city, string state, string name)
        {
            
            await UpdateFarmAsync(farmId, address, zipcode, city, state, name);

            
            return RedirectToPage("/Index"); 
        }

        private async Task UpdateFarmAsync(int farmId, string address, string zipcode, string city, string state, string name)
        {
            FarmUpdater farmUpdater = new FarmUpdater(_configuration);
            await farmUpdater.UpdateFarm(farmId, address, zipcode, city, state, name);
        }
    }

    internal class FarmUpdater
    {
        private readonly IConfiguration _configuration;

        public FarmUpdater(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        internal async Task UpdateFarm(int farmId, string address, string zipcode, string city, string state, string name)
        {
            
            
            
            throw new NotImplementedException();
        }
    }
}
