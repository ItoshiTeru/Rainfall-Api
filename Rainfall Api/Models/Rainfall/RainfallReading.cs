using Rainfall_Api.Helpers;

namespace Rainfall_Api.Models.Rainfall
{
    /// <summary>
    /// Details of a rainfall reading
    /// </summary>
    public class RainfallReading
    {
        public string dateMeasured { get; set; }
        public decimal amountMeasured { get; set; }

        public RainfallReading()
        {
            this.dateMeasured = DateTime.MinValue.DateToString();
            this.amountMeasured = 0;
        }

        public RainfallReading(string dateMeasured, decimal amountMeasured)
        {
            this.dateMeasured = dateMeasured;
            this.amountMeasured = amountMeasured;
        }

        public RainfallReading(DateTime dateMeasured, decimal amountMeasured)
        {
            this.dateMeasured = dateMeasured.DateToString();
            this.amountMeasured = amountMeasured;
        }
    }
}
