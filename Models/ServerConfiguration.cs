namespace Wolk.Models
{
    public class ServerConfiguration
    {
        private static ServerConfiguration _instance;
        private IConfiguration _configuration;

        public string SqlConnectionString => _configuration?.GetConnectionString("DefaultConnection") ?? string.Empty;

        private ServerConfiguration(IConfigurationRoot configuration)
        {
            _configuration = configuration;
        }

        public static ServerConfiguration Instance
        {
            get
            {
                if (_instance == null)
                {
                    var configBuilder = new ConfigurationBuilder()
                        .AddEnvironmentVariables()
                        .AddJsonFile("Properties/generalWolkConfiguration.json");
                    _instance = new ServerConfiguration(configBuilder.Build());
                }
                return _instance;
            }
        }
    }
}
