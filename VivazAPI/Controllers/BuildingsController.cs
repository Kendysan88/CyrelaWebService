using Microsoft.AspNetCore.Mvc;
using VivazAPI.Data;
using VivazAPI.Models;

namespace VivazAPI.Controllers
{
    [ApiController]
    [Route("api/buildings")]
    public class BuildingsController : ControllerBase
    {
        private readonly IRepository<Building> _repository;

        public BuildingsController(IRepository<Building> repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            var buildings = _repository.FindAll();
            return Ok(buildings);
        }
    }
}
