namespace Rainfall_Api.Models.Rainfall
{
    /// <summary>
    /// Details of a rainfall reading
    /// </summary>
    public class RainfallReadingResponse
    {
        public List<RainfallReading> readings { get; set; }

        public RainfallReadingResponse()
        {
            this.readings = new List<RainfallReading>();
        }

        public RainfallReadingResponse(List<RainfallReading> readings)
        {
            this.readings = readings;
        }
    }
}
