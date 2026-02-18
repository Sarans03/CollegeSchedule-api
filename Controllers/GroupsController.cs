using CollegeSchedule.DTO;
using CollegeSchedule.Services;
using Microsoft.AspNetCore.Mvc;

namespace CollegeSchedule.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GroupsController : ControllerBase
    {
        private readonly IScheduleService _service;

        public GroupsController(IScheduleService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<GroupDto>>> GetGroups()
        {
            var groups = await _service.GetAllGroups();
            return Ok(groups);
        }
    }
}