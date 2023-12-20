namespace Rainfall_Api.Models.Rainfall
{
    public class RainfallReadingResponseExternal
    {
        public List<RainfallReadingExternal> items { get; set; }

        public RainfallReadingResponseExternal()
        {
            this.items = new List<RainfallReadingExternal>();
        }

        public RainfallReadingResponseExternal(List<RainfallReadingExternal> items)
        {
            this.items = items;
        }
    }
}
