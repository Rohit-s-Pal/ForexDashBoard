namespace ForexAPI
{
    public static class ConfigBridge
    {
        private static IConfiguration _configuration;

        public static void Initialize(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static string Get(string key)
        {
            return _configuration[key];
        }
    }

}
