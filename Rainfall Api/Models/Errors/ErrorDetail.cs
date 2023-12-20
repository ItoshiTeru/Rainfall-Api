namespace Rainfall_Api.Models.Errors
{
    public class ErrorDetail
    {
        public string propertyName { get; set; }
        public string message { get; set; }

        public ErrorDetail() 
        { 
            this.propertyName = string.Empty;
            this.message = string.Empty;
        }

        public ErrorDetail(string propertyName, string message)
        {
            this.propertyName = propertyName;
            this.message = message;
        }
    }
}
