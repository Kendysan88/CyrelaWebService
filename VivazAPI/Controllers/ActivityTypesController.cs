using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VivazAPI.Data;
using VivazAPI.Dtos;

namespace VivazAPI.Controllers
{
    [Route("api/activity_types")]
    [ApiController]
    public class ActivityTypesController : ControllerBase
    {
        private readonly IActivityTypeRepository _repository;
        private readonly IMapper _mapper;

        public ActivityTypesController(IActivityTypeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET: api/ActivityTypes
        [HttpGet]
        public IActionResult Get()
        {
            var activityTypes = _repository.FindAll();
            return Ok(_mapper.Map<IEnumerable<ActivityTypeReadDto>>(activityTypes));
        }

        // GET: api/ActivityTypes/warranty
        [HttpGet("{warranty}")]
        public IActionResult GetWarranty(int warranty)
        {
            var activityTypes = _repository.FindByWarranty(warranty);               
            return Ok(activityTypes);
        }
       
        /*
        private bool ActivityTypeExists(Guid id)
        {
            return _context.ActivityTypes.Any(e => e.Id == id);
        }
        */
    }
}
