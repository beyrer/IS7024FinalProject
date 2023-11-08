using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ParkPlannerAddresses;
using System.Net.Http;

namespace ParkPlanner.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        static readonly HttpClient client = new HttpClient();
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

            var task = client.GetAsync("https://ridb.recreation.gov/api/v1/facilityaddresses?limit=50&offset=0&apikey=4ae269f1-67d1-4fd4-9cb1-d3a343bb9045");
            HttpResponseMessage result = task.Result;
            IList<FacilitiesAddresses> facilitiesAddresses = new List<FacilitiesAddresses>();
            if (result.IsSuccessStatusCode)
            {
                Task<string> readString = result.Content.ReadAsStringAsync();
                string jsonString = readString.Result;
                facilitiesAddresses = FacilitiesAddresses.FromJson(jsonString);

            }
            ViewData["FacilitiesAddresses"] = facilitiesAddresses;

        }


    }
}