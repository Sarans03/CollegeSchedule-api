using CollegeSchedule.Data;
using CollegeSchedule.DTO;
using CollegeSchedule.Models;
using CollegeSchedule.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CollegeSchedule.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScheduleController : ControllerBase
    {
        private readonly IScheduleService _service;

        public ScheduleController(IScheduleService service, AppDbContext db)
        {
            _service = service;
        }

        [HttpGet("{groupName}/schedule")]
        public async Task<IActionResult> GetSchedule(
            string groupName,
            DateTime startDate,
            DateTime endDate)
        {
            var result = await _service.GetScheduleForGroup(groupName, startDate, endDate);
            return Ok(result);
        }
    }
}