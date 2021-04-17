using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivazAPI.Data;
using VivazAPI.Models;

namespace VivazAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchedulesController : ControllerBase
    {
        private readonly ScheduleRepository<Schedule> _repository;
        //private readonly IMapper _mapper;

        public SchedulesController(ScheduleRepository<Schedule> repository)
        {
            _repository = repository;
        }
        // GET: api/Users
        [HttpGet]
        public ActionResult<IEnumerable<Schedule>> GetSchedule()
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
