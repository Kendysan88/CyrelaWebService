using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivazAPI.Data;
using VivazAPI.Domain;
using VivazAPI.Dtos;
using VivazAPI.Models;

namespace VivazAPI.Controllers
{
   
    [ApiController]
    [Route("api/schedule")]
    public class SchedulesController : ControllerBase
    {
        private readonly IScheduleRepository _repository;
        private readonly IRepository<User> _repositoryUser;
        //private readonly IRepository<Occurrence> _repositoryOccurrence;
        private readonly IScheduleAvailability _scheduleAvailability;
        private readonly IMapper _mapper;

        public SchedulesController(
            IScheduleRepository repository,
            IRepository<User> repositoryUser,
            //IRepository<Occurrence> repositoryOccurrence,
            IScheduleAvailability scheduleAvailability,
            IMapper mapper)
        {
            _repository = repository;
            _repositoryUser = repositoryUser;
            //_repositoryOccurrence = repositoryOccurrence;
            _scheduleAvailability = scheduleAvailability;
            _mapper = mapper;
        }
        // GET: api/Users
        [HttpGet]
        public ActionResult<IEnumerable<ScheduleReadDto>> GetSchedule()
        {
            var schedules = _repository.FindAllWithAssociations();
            return Ok(_mapper.Map<IEnumerable<ScheduleReadDto>>(schedules));
        }
        //GET api/schedule/{id}
        [HttpGet("{id}")]
        public IActionResult GetScheduleById(Guid id)
        {
            var schedule = _repository.FindByIdWithAssociations(id);
            if (schedule != null)
            {
                return Ok(_mapper.Map<ScheduleReadDto>(schedule)); 
            }
            else
            {
                return NotFound();
            }

        }
        //POST api/schedule
        [HttpPost]
        public IActionResult CreateSchedule(ScheduleCreateDto scheduleCreateDto)
        {
            var scheduleModel = _mapper.Map<Schedule>(scheduleCreateDto);
            var user = _repositoryUser.FindById(scheduleModel.EmployeeId);

            if (user == null) return NotFound();

            if(_scheduleAvailability.IsDataAvailable(user.Schedules, scheduleModel.ActualStart))
            {
                return UnprocessableEntity("A data solicitada não está disponível. Por favor, escolha outra.");
            }

            _repository.Create(scheduleModel);

            if (_repository.SaveChanges())
            {
                return Ok(_mapper.Map<ScheduleReadDto>(scheduleModel));
            }
            else
            {
                return BadRequest();
            }           
        }

    }
}
/*   //POST api/commands
 *   , Name = "GetScheduleById")
        [HttpPost]
        public ActionResult<Schedule> CreateSchedule(Schedule schedule)
        {
            _repository.Create(schedule);
            _repository.SaveChanges();

            return CreatedAtAction("GetSchedule", new { id = schedule.Id }, schedule);
        }
        // DELETE: api/Schedule/5
        [HttpDelete("{id}")]
        public IActionResult Delete (Guid id)
        {
            var schedule = _repository.FindById(id);
            if (schedule == null)
            {
                return NotFound();
            }
            _repository.Delete(schedule);
            _repository.SaveChanges();

            return NoContent();           
        }*/