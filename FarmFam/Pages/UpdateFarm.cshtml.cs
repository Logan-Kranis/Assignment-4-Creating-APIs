using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json; // Make sure to install Newtonsoft.Json via NuGet
using assigment4_api.entities;

namespace SmartCrop.Pages
{
    public class UpdateFarmModel : PageModel
    {
        private readonly IHttpClientFactory _clientFactory;

        public UpdateFarmModel(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        //[BindProperty]
        public Farm Farm { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                $"http://localhost:5078/api/Farms/GetFarm/{id}"); // Use your actual API URL
            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Farm = await System.Text.Json.JsonSerializer.DeserializeAsync<Farm>(responseStream);
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var client = _clientFactory.CreateClient();
            var farmJson = JsonConvert.SerializeObject(Farm);
            var response = await client.PostAsync($"http://localhost:5078/api/Farms", new StringContent(farmJson, System.Text.Encoding.UTF8, "application/json"));

            if (response.IsSuccessStatusCode)
            {
                return RedirectToPage("./Index"); // Redirect to a confirmation page or back to the list
            }

            // Handle failure
            ModelState.AddModelError(string.Empty, "An error occurred while updating the farm.");
            return Page();
        }
    }
}
