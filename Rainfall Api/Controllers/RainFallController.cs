using Microsoft.AspNetCore.Mvc;
using Rainfall_Api.MainLogic.Rainfall;
using Rainfall_Api.Models.Errors;

namespace Rainfall_Api.Controllers
{
    [ApiController]
    [Route("rainfall/")]
    public class RainFallController : ControllerBase
    {

        private readonly IRainFallApi rainFallApi;

        public RainFallController(IRainFallApi rainFallApi)
        {
            this.rainFallApi = rainFallApi;
        }


        /// <summary>
        /// Retrieve the latest readings for the specified stationId
        /// </summary>
        /// <param name="stationId">The id of the reading station</param>
        /// <param name="count">The number of readings to return</param>
        /// <returns></returns>
        [HttpGet]
        [Route("id/{stationId}/readings")]
        public async Task<IActionResult> GetReadingsByStation([FromRoute] string stationId, [FromQuery] string count = "10")
        {
            int count_parsed;




            if(!Int32.TryParse(count, out count_parsed)) 
            {
                return StatusCode(400, new Error("Invalid request", new List<ErrorDetail>
                {
                    new ErrorDetail("count", "Count is not a valid number")
                }));
            }

            if (count_parsed <= 0)
            {
                return StatusCode(400, new Error("Invalid request", new List<ErrorDetail>
                {
                    new ErrorDetail("count", "Count must be greater than 0")
                }));
            }

            var result = await rainFallApi.GetReadingsAsync(stationId, count_parsed);

            if(result.Error != null) 
            {
                return StatusCode(500, new Error("Internal server error"));
            }

            if(result.Result.readings.Count == 0)
            {
                return StatusCode(404, new Error("No readings found for the specified stationId"));
            }

            return Ok(result.Result);
        }
    }
}