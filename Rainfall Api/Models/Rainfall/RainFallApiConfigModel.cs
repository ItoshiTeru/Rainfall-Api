namespace Rainfall_Api.Models.Rainfall
{
    public class RainFallApiConfigModel
    {
        public string url { get; set; }

        public RainFallApiConfigModel()
        { 
            url = string.Empty;
        }

        public RainFallApiConfigModel(string url)
        {
            this.url = url;
        }
    }
}
