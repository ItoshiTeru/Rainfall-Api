namespace Rainfall_Api.Models.Responses
{
    public class BaseResult<T,K>
    {
        public T? Result { get; set; }
        public K? Error { get; set; }

        public BaseResult(T result = default, K error = default) 
        {
            this.Result = result;
            this.Error = error;
        }
    }
}
