using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using VivazAPI.Data;
using VivazAPI.Models;
using VivazAPI.Dtos;

namespace VivazAPI.Controllers
{

    [ApiController]
    [Route("api/schedules")]
    public class SchedulesController : ControllerBase
    {
        private readonly IScheduleRepository _repository;
        private readonly IRepository<User> _repositoryUser;
        private readonly IMapper _mapper;

        public SchedulesController(
            IScheduleRepository repository,
            IRepository<User> repositoryUser,
            IMapper mapper)
        {
            _repository = repository;
            _repositoryUser = repositoryUser;
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

        }
        //POST api/schedule
        [HttpPost]
        public IActionResult CreateSchedule(ScheduleCreateDto scheduleCreateDto)
        {
            var scheduleModel = _mapper.Map<Schedule>(scheduleCreateDto);

            if(scheduleModel.ActualStart.Date > scheduleModel.ActualEnd.Date)
            {
                return UnprocessableEntity("A data inicial deve ser menor ou igual a data final.");
            }

            if (_repository.IsAnyScheduleAtRange(scheduleCreateDto.EmployeeId, scheduleCreateDto.ActualStart, scheduleCreateDto.ActualEnd))
            {
                return UnprocessableEntity("O funcionário indicado já possui um agendamento para esse intervalo.");
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

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, ScheduleUpdateDto scheduleUpdateDto)
        {
            var schedule = _repository.FindByIdWithAssociations(id);

            if (schedule == null) return NotFound();

            if (scheduleUpdateDto.ActualStart.Date > scheduleUpdateDto.ActualEnd.Date)
            {
                return UnprocessableEntity("A data inicial dev ser menor ou igual a data final.");
            }

            if (_repository.IsAnyScheduleAtRange(scheduleUpdateDto.EmployeeId, scheduleUpdateDto.ActualStart, scheduleUpdateDto.ActualEnd))
            {
                return UnprocessableEntity("O funcionário indicado já possui um agendamento para esse intervalo.");
            }

            _mapper.Map(scheduleUpdateDto, schedule);
            _repository.Update(schedule);

            if (_repository.SaveChanges())
            {
                return Ok(_mapper.Map<ScheduleWithDetailsReadDto>(schedule));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var schedule = _repository.FindById(id);

            if (schedule == null) return NotFound();

            _repository.Delete(schedule);

            if (_repository.SaveChanges())
            {
                return NoContent();
            }
            else
            {
                return BadRequest();
            }
        }

    }
}
