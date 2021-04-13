using Microsoft.AspNetCore.Mvc;
using VivazAPI.Data;
using VivazAPI.Models;

namespace VivazAPI.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IRepository<User> _repository;

        public UsersController(IRepository<User> repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
           return Ok(); 
        }

        [HttpGet("{UserId}")]
        public IActionResult Get(string UserId)
        {
           return Ok(); 
        }

        [HttpPost]
        public IActionResult Post(User user)
        {
           if(!ModelState.IsValid){
              return BadRequest(ModelState);
           }
           return Ok(); 
        }

        [HttpPut("{UserId}")]
        public IActionResult Put(string UserId)
        {
           return Ok(); 
        }

        [HttpDelete("{UserId}")]
        public IActionResult Delete(string UserId)
        {
           return Ok(); 
        }
    }
}
