namespace Rainfall_Api.Models.Errors
{
    public class Error
    {
        public string message { get; set; }
        public List<ErrorDetail> items { get; set; }

        public Error()
        { 
            this.message = string.Empty;
            this.items = new List<ErrorDetail>();
        }

        public Error(string message)
        {
            this.message = message;
            this.items = new List<ErrorDetail>();
        }

        public Error(string message, List<ErrorDetail> items)
        {
            this.message = message;
            this.items = items;
        }
    }
}
