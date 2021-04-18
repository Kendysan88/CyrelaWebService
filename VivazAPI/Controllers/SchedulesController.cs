using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivazAPI.Data;
using VivazAPI.Dtos;
using VivazAPI.Models;

namespace VivazAPI.Controllers
{
   
    [ApiController]
    [Route("api/schedule")]
    public class SchedulesController : ControllerBase
    {
        private readonly IScheduleRepository _repository;
        private readonly IMapper _mapper;

        //private readonly IMapper _mapper;

        public SchedulesController(IScheduleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        // GET: api/Users
        [HttpGet]
        public ActionResult<IEnumerable<ScheduleReadDto>> GetSchedule()
        {
            var scheduleItem = _repository.FindAll();
            return Ok(scheduleItem);
        }
        //GET api/commands/{id}
        [HttpGet("{id}", Name = "GetScheduleById")]
        public ActionResult<Schedule> GetScheduleById(Guid id)
        {
            var schedule = _repository.FindById(id);
            if (schedule == null)
            {
                return NotFound();
            }
            return schedule;
        }
        
        //POST api/commands
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
        }

    }
}
