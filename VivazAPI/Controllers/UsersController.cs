using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VivazAPI.Data;
using VivazAPI.Dtos;

namespace VivazAPI.Controllers
{

    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public readonly IMapper _mapper;

        public UsersController(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        // GET: api/Users
        [HttpGet]
        public ActionResult<IEnumerable<UserReadDto>> GetUsers()
        {
            var users = _repository.FindAllUsers();
            return Ok(_mapper.Map<IEnumerable<UserReadDto>>(users));
        }
        //GET: api/user/5
        //[HttpGet("{Id}")]
        //public IActionResult GetById(Guid Id)
        //{
        //    var user = _repository.FindById(Id);

        //    if (user != null)
        //    {
        //        return Ok(_mapper.Map<UserReadDto>(user));
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //}
        //GET: api/user/admin
        [HttpGet("{role}")]
        public IActionResult GetByRole(string role)
        {
            var userItem = _repository.FindByRole(role);
            return Ok(_mapper.Map<IEnumerable<UserReadDto>>(userItem));
        }
        /*      
        private bool UserExists(Guid id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
        */
    }
}
