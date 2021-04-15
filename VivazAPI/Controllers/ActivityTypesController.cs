using Microsoft.AspNetCore.Mvc;
using VivazAPI.Data;
using VivazAPI.Models;

namespace VivazAPI.Controllers
{
    [ApiController]
    [Route("api/activity_types")]
    public class ActivityTypesController : ControllerBase
    {
        private readonly IRepository<ActivityType> _repository;

        public ActivityTypesController(IRepository<ActivityType> repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            var activityTypes = _repository.FindAll();
            return Ok(activityTypes);
        }
    }
}
