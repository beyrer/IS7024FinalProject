namespace ParkPlanner
{
    public class ConfigurationResolver
    {
        private readonly IConfiguration _configuration;
        public ConfigurationResolver(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConfiguration(string key)
        {
            return _configuration[key];
        }
    }
}
