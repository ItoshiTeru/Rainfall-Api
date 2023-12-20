using Rainfall_Api.Models.Errors;
using Rainfall_Api.Models.Rainfall;
using Rainfall_Api.Models.Responses;

namespace Rainfall_Api.MainLogic.Rainfall
{
    public interface IRainFallApi
    {
        public Task<BaseResult<RainfallReadingResponse, Error>> GetReadingsAsync(string stationId, int count);
    }
}
