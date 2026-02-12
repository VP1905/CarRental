using MaintainenceAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace MaintainenceAPI.Controllers
{
    [ApiController]
    [Route("api/maintenance")]
    public class MaintenanceController : ControllerBase
    {
        private readonly IRepairHistoryService _service;
        public MaintenanceController(IRepairHistoryService service)
        {
            _service = service;
        }
        [HttpGet("vehicles/{vehicleId}/repairs")]
        public IActionResult GetRepairHistory(int vehicleId)
        {
            var history = _service.GetByVehicleId(vehicleId);
            return Ok(history);
        }
    }
}
