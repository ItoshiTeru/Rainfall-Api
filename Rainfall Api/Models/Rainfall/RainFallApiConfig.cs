namespace Rainfall_Api.Models.Rainfall
{
    public class RainFallApiConfig
    {
        private static RainFallApiConfigModel? config = null;
        private RainFallApiConfig() { }

        public static void Configure(RainFallApiConfigModel config)
        {
            if (RainFallApiConfig.config != null)
            {
                throw new Exception("Rainfall api has been configured already");
            }

            RainFallApiConfig.config = config;
        }

        public static RainFallApiConfigModel GetConfig()
        {
            return RainFallApiConfig.config;
        }
    }
}
