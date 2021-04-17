using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VivazAPI.Data;
using VivazAPI.Dtos;
using VivazAPI.Models;

namespace VivazAPI.Controllers
{
    [ApiController]
    [Route("api/activity_types")]
    public class ActivityTypesController : ControllerBase
    {
        private readonly IRepository<ActivityType> _repository;

        private readonly IMapper _mapper;

        public ActivityTypesController(IRepository<ActivityType> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            var activityTypes = _repository.FindAll();
            return Ok(_mapper.Map<IEnumerable<ActivityTypeReadDto>>(activityTypes));
        }
    }
}
