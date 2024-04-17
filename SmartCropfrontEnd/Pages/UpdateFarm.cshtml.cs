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
            // This method handles GET requests to this page
        }

        public async Task<IActionResult> OnPostAsync(int farmId, string address, string zipcode, string city, string state, string name)
        {
            // Call the method to update the farm
            await UpdateFarmAsync(farmId, address, zipcode, city, state, name);

            // Redirect to another page or return a response
            return RedirectToPage("/Index"); // Redirect to the index page after updating
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
            // Implement your farm update logic here
            // You can use _configuration to access app settings if needed
            // For now, let's just throw a NotImplementedException
            throw new NotImplementedException();
        }
    }
}
