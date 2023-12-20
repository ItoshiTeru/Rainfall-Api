using Rainfall_Api.Models.Errors;
using Rainfall_Api.Models.Rainfall;
using Rainfall_Api.Models.Responses;

namespace Rainfall_Api.MainLogic.Rainfall
{
    public class RainfallApiExecutor : IRainFallApi
    {
        private readonly HttpClient httpClient;

        public RainfallApiExecutor()
        { 
            this.httpClient = new HttpClient();
        }

        public async Task<BaseResult<RainfallReadingResponse, Error>> GetReadingsAsync(string stationId, int count)
        {
            var api_config = RainFallApiConfig.GetConfig();

            string url = $"{api_config.url}flood-monitoring/id/stations/{stationId}/readings?_sorted&_limit={count}";

            RainfallReadingResponseExternal externalReadings;

            try
            {
                var response = await httpClient.GetAsync(url);

                if(!response.IsSuccessStatusCode) 
                {
                    return new BaseResult<RainfallReadingResponse, Error>(null, new Error());
                }

                externalReadings = await response.Content.ReadFromJsonAsync<RainfallReadingResponseExternal>();
            }
            catch (Exception ex) 
            {
                return new BaseResult<RainfallReadingResponse, Error>(null, new Error());
            }

            var readings = ParseExternalResponse(externalReadings);

            return new BaseResult<RainfallReadingResponse, Error>(readings);
        }

        private RainfallReadingResponse ParseExternalResponse(RainfallReadingResponseExternal externalResponse)
        {
            var response = new RainfallReadingResponse();

            if (externalResponse == null
                || externalResponse.items == null
                || externalResponse.items.Count == 0)
            {
                return response;
            }

            foreach (var item in externalResponse.items)
            {
                var temp_item = new RainfallReading(item.dateTime, item.value);

                response.readings.Add(temp_item);
            }

            return response;
        }
    }
}
