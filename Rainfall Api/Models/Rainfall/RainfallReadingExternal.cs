namespace Rainfall_Api.Models.Rainfall
{
    public class RainfallReadingExternal
    {
        public string dateTime { get; set; }
        public decimal value { get; set; }

        public RainfallReadingExternal()
        { 
            this.dateTime = string.Empty;
            this.value = 0;
        }

        public RainfallReadingExternal(string dateTime, decimal value)
        {
            this.dateTime = dateTime;
            this.value = value;
        }   
    }
}
