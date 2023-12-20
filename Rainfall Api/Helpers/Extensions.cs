namespace Rainfall_Api.Helpers
{
    public static class Extensions
    {
        public static string DateToString(this DateTime date)
        {
            return date.ToString("yyyy-MM-ddTHH:mm:ss");
        }
    }
}
