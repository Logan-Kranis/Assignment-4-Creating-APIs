using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Threading.Tasks;


namespace FarmFam.Pages
{
    public class DeleteFarmModel : PageModel
    {
      
 
            private readonly IHttpClientFactory _clientFactory;

            public DeleteFarmModel(IHttpClientFactory clientFactory)
            {
                _clientFactory = clientFactory;
            }

            public async Task<IActionResult>
        OnGetAsync(int id)
            {
                var client = _clientFactory.CreateClient();
                var response = await client.DeleteAsync($"http://localhost:5078/api/Farms/DeleteFarm/{id}");

                if (response.IsSuccessStatusCode)
                {
                 
                    TempData["SuccessMessage"] = "Farm successfully deleted.";
                    return RedirectToPage("./Index"); 
                }
                else
                {

                    ModelState.AddModelError(string.Empty, "Your Farm Has Been Deleted.");
                    return Page();
                }
            }
        }
    }



