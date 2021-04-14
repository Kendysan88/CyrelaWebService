using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public class ActivityTypesController : ControllerBase
    {
        private readonly DataContext _context;

        public ActivityTypesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/ActivityTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ActivityType>>> GetActivityTypes()
        {
            return await _context.ActivityTypes.ToListAsync();
        }

        // GET: api/ActivityTypes/5
        [HttpGet("{garantia=}")]
        public IQueryable<ActivityType> GetUserByName(int garantia)
        {
            var activityTypes = _context.ActivityTypes.Where(x => x.WarrantyInYears == garantia);

            return activityTypes;
        }
        //[HttpGet("{garantia}")]
        //public async Task<ActionResult<ActivityType>> GetActivityType(Guid id)
        //{
        //    var activityType = await _context.ActivityTypes.FindAsync(id);

        //    if (activityType == null)
        //    {
        //        return NotFound();
        //    }

        //    return activityType;
        //}

        // PUT: api/ActivityTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActivityType(Guid id, ActivityType activityType)
        {
            if (id != activityType.Id)
            {
                return BadRequest();
            }

            _context.Entry(activityType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActivityTypeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ActivityTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ActivityType>> PostActivityType(ActivityType activityType)
        {
            _context.ActivityTypes.Add(activityType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetActivityType", new { id = activityType.Id }, activityType);
        }

        // DELETE: api/ActivityTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivityType(Guid id)
        {
            var activityType = await _context.ActivityTypes.FindAsync(id);
            if (activityType == null)
            {
                return NotFound();
            }

            _context.ActivityTypes.Remove(activityType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ActivityTypeExists(Guid id)
        {
            return _context.ActivityTypes.Any(e => e.Id == id);
        }
    }
}
