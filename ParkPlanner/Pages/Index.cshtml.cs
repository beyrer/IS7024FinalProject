using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ParkPlannerPark;
using System.Net.Http;

namespace ParkPlanner.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ConfigurationResolver _configurationResolver;
        static readonly HttpClient client = new HttpClient();
        public IndexModel(ILogger<IndexModel> logger,
            ConfigurationResolver configurationResolver)
        {
            _logger = logger;
            _configurationResolver = configurationResolver;
        }

        public void OnGet()
        {
            
            try
            {
                var URL = _configurationResolver.GetConfiguration("npsURL");
                var task = client.GetAsync(URL);
                HttpResponseMessage result = task.Result;
                List<Datum> park = new List<Datum>();
                if (result.IsSuccessStatusCode)
                {
                    Task<string> readString = result.Content.ReadAsStringAsync();
                    string jsonString = readString.Result;
                    park = Park.FromJson(jsonString).Data;

                }
                else
                {
                    _logger.LogInformation("Http Request Failure", result.StatusCode);
                }
                ViewData["Park"] = park;
            }
            catch (Exception)
            {

                ViewData["ErrorMessage"] = "Http Call and JSON Parsing resulted in an Exception";
            }

        }


    }
}