using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using VivazAPI.Data;
using VivazAPI.Dtos;
using VivazAPI.Models;

namespace VivazAPI.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IRepository<User> _repository;

        private readonly IUserRepository _repositoryUser;

        private readonly IBuildingRepository _buildingRepository;

        private readonly IOccurrenceRepository _occurrenceRepository;

        private readonly IMapper _mapper;

        public UsersController(
            IRepository<User> repository,
            IBuildingRepository buildingRepository,
            IOccurrenceRepository occurrenceRepository,
            IUserRepository repositoryUser,
            IMapper mapper
        )
        {
            _repository = repository;
            _repositoryUser = repositoryUser;
            _buildingRepository = buildingRepository;
            _occurrenceRepository = occurrenceRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserReadDto>> Get()
        {
            var users = _repositoryUser.FindAll();
            return Ok(_mapper.Map<IEnumerable<UserReadDto>>(users));
        }

        [HttpGet("{userId}")]
        public IActionResult Get(Guid userId)
        {
            var user = _repository.FindById(userId);

            if (user != null)
            {
                return Ok(_mapper.Map<UserReadDto>(user));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{userId}/buildings")]
        public IActionResult GetBuildings(Guid userId)
        {
            if (!_repository.Exists(userId)) return NotFound();

            var buildings = _buildingRepository.FindAllByCustomerId(userId);
            return Ok(_mapper.Map<IEnumerable<BuildingWithDetailsReadDto>>(buildings));
        }

        [HttpGet("{userId}/occurrences")]
        public IActionResult GetOccurrences(Guid userId)
        {
            if (!_repository.Exists(userId)) return NotFound();

            var occurrences = _occurrenceRepository.FindAllByCustomerId(userId);
            return Ok(_mapper.Map<IEnumerable<OccurrenceWithDetailsReadDto>>(occurrences));
        }
        [HttpGet("[controller]/schedules")]
        public ActionResult<IEnumerable<UserReadWithDetailsDto>> GetSchedules()
        {
            var users = _repositoryUser.FindAllUsers();
            return Ok(_mapper.Map<IEnumerable<UserReadWithDetailsDto>>(users));
        }

        [HttpPost]
        public IActionResult Post(UserCreateDto userCreateDto)
        {
            var userModel = _mapper.Map<User>(userCreateDto);

            _repository.Create(userModel);

            if (_repository.SaveChanges())
            {
                return Ok(_mapper.Map<UserReadDto>(userModel));
            }
            else
            {
                return BadRequest();
            }

        }
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, UserUpdateDto userUpdateDto)
        {
            var user = _repository.FindById(id);

            if (user == null) return NotFound();

            _mapper.Map(userUpdateDto, user);
            _repository.Update(user);

            if (_repository.SaveChanges())
            {
                return Ok(_mapper.Map<UserReadDto>(user));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var user = _repository.FindById(id);

            if (user == null) return NotFound();

            _repository.Delete(user);

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
