using HealthTracker.Entities.Dto.Device;
using HealthTracker.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HealthTracker.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController(IServiceManager serviceManager) : ControllerBase
    {
        private readonly IServiceManager serviceManager = serviceManager;

        [HttpPost("data")]
        [Consumes("application/json")]
        public async Task<IActionResult> NewData([FromBody] DeviceDataDto deviceDataDto)
        {

            Guid DeviceGuid;
            if (!Guid.TryParse(Request.Headers["Device-Guid"].ToString(), out DeviceGuid))
                return BadRequest("Bad Device Guid");

            if (deviceDataDto is null)
                return BadRequest("Invalid Device Data");

            DeviceDetailsDto deviceDetailsDto = await serviceManager.DeviceService.GetDeviceDetails(new DeviceGuidDto(DeviceGuid));
            if (deviceDetailsDto == null)
                return NotFound("Invalid Device Guid");
            
            if (deviceDataDto is null)
                return BadRequest("Invalid Device Data");

            await serviceManager.DeviceDataService.CreateDeviceData(deviceDataDto, deviceDetailsDto);

            return Ok();
        }
    }
}
