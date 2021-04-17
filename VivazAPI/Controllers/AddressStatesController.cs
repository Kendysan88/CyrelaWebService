using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VivazAPI.Data;
using VivazAPI.Models;

namespace VivazAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressStatesController : ControllerBase
    {
        private readonly IRepository<AddressState> _repository;

        public AddressStatesController(IRepository<AddressState> repository)
        {
            _repository = repository;
        }

        // GET: api/AddressStates
        [HttpGet]
        public ActionResult<IEnumerable<AddressState>> GetAddressStates()
        {
            var userItem = _repository.FindAll();
            return Ok(userItem);
        }

        /*  // GET: api/AddressStates/5
          [HttpGet("{id}")]
          public async Task<ActionResult<AddressState>> GetAddressState(Guid id)
          {
              var addressState = await _context.AddressStates.FindAsync(id);

              if (addressState == null)
              {
                  return NotFound();
              }

              return addressState;
          }

          // PUT: api/AddressStates/5
          // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
          [HttpPut("{id}")]
          public async Task<IActionResult> PutAddressState(Guid id, AddressState addressState)
          {
              if (id != addressState.Id)
              {
                  return BadRequest();
              }

              _context.Entry(addressState).State = EntityState.Modified;

              try
              {
                  await _context.SaveChangesAsync();
              }
              catch (DbUpdateConcurrencyException)
              {
                  if (!AddressStateExists(id))
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

          // POST: api/AddressStates
          // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
          [HttpPost]
          public async Task<ActionResult<AddressState>> PostAddressState(AddressState addressState)
          {
              _context.AddressStates.Add(addressState);
              await _context.SaveChangesAsync();

              return CreatedAtAction("GetAddressState", new { id = addressState.Id }, addressState);
          }

          // DELETE: api/AddressStates/5
          [HttpDelete("{id}")]
          public async Task<IActionResult> DeleteAddressState(Guid id)
          {
              var addressState = await _context.AddressStates.FindAsync(id);
              if (addressState == null)
              {
                  return NotFound();
              }

              _context.AddressStates.Remove(addressState);
              await _context.SaveChangesAsync();

              return NoContent();
          }

          private bool AddressStateExists(Guid id)
          {
              return _context.AddressStates.Any(e => e.Id == id);
          }*/
    }
}
