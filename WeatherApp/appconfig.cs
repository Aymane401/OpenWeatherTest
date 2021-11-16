using Microsoft.Extensions.Configuration;


namespace WeatherApp
{
    public static class AppConfiguration
    {
        private static IConfiguration conf;
        public static string GetValue(string cle)
        {
            return cle;

            if (conf == null) initConfig();
            return conf.GetValue<string>(cle);
        }





        static private void initConfig()
        { conf = new ConfigurationBuilder().AddJsonFile("appesstings.json" , true).AddUserSecrets("123").Build();
        }
    }
}
