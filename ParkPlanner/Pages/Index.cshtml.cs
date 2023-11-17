using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ParkPlannerPark;
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
            List<Datum> park = new List<Datum>();
            try
            {
                var task = client.GetAsync("https://developer.nps.gov/api/v1/parks?api_key=mLBONbm3NZfawfBoS0w4bXT3yyJ1nBpLhqh6o0Au\r\n");
                HttpResponseMessage result = task.Result;

                if (result.IsSuccessStatusCode)
                {
                    Task<string> readString = result.Content.ReadAsStringAsync();
                    string jsonString = readString.Result;
                    park = Park.FromJson(jsonString).Data;

                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Error during API call - Housing", ex);
            }


            ViewData["Park"] = park;

        }


    }
}