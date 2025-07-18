using Microsoft.Extensions.Configuration;

namespace DALForexAPI
{
    public static class Configuration
    {
        private static IConfiguration _configuration;

        public static void Initialize(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static string GetConfigFilePath()
        {
            return _configuration["ConfigFilePath"];
        }

        public static string GetDBSourceKey()
        {
            return _configuration["DBSourceKey"];
        }

        public static string GetDBObjectOwner()
        {
            return _configuration["DBObjectOwner"];
        }

        


    }
}


