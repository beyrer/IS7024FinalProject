using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;

namespace ParkPlanner.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

            var task = client.GetAsync("https://ridb.recreation.gov/api/v1/facilityaddresses?limit=50&offset=0\r\n")
                HttpsResponseMessage result = task.Result;
            if (result.IsSuccessStatusCode)
            {
                result.Content.ReadAsStringAsync()
                Facilities.FromJson();

            }


        }


    }
}