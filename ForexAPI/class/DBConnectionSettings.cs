namespace ForexAPI
{
    public static class DBConnectionSettings
    {
        public static string AppDBName => ConfigBridge.Get("DBConnectionSettings:AppDBName");
        public static string DBObjectOwner => ConfigBridge.Get("DBConnectionSettings:DBObjectOwner");
        public static string DBSourceKey => ConfigBridge.Get("DBConnectionSettings:DBSourceKey");
        public static string ConfigFilePath => ConfigBridge.Get("DBConnectionSettings:ConfigFilePath");
    }
}
