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

            var task = client.GetAsync("https://developer.nps.gov/api/v1/parks?api_key=mLBONbm3NZfawfBoS0w4bXT3yyJ1nBpLhqh6o0Au\r\n");
            HttpResponseMessage result = task.Result;
            List<Datum> park = new List<Datum>();
            if (result.IsSuccessStatusCode)
            {
                public async Task OnGet()
{
    var result = await client.GetAsync("https://developer.nps.gov/api/v1/parks?api_key=mLBONbm3NZfawfBoS0w4bXT3yyJ1nBpLhqh6o0Au");

    if (result.IsSuccessStatusCode)
    {
        var jsonString = await result.Content.ReadAsStringAsync();
        List<Datum> park = Park.FromJson(jsonString).Data;
        ViewData["Park"] = park;
    }
    else
    {
        // Handle non-success status code
    }
}
                park = Park.FromJson(jsonString).Data;

            }
            ViewData["Park"] = park;

        }


    }
}