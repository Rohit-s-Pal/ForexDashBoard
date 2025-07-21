using Microsoft.Extensions.Configuration;

namespace ForexAPI
{
    public static class Configuration
    {
        private static IConfiguration _configuration;

        public static void Initialize(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static string GetWebApiLogPath()
        {
            return _configuration["WebApiLogPath"];
        }

        

    }
}
