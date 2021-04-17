using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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

        private readonly IBuildingRepository _buildingRepository;

        private readonly IOccurenceRepository _occurenceRepository;

        public readonly IMapper _mapper;

        public UsersController(
            IRepository<User> repository,
            IBuildingRepository buildingRepository,
            IOccurenceRepository occurenceRepository,
            IMapper mapper
        )
        {
            _repository = repository;
            _buildingRepository = buildingRepository;
            _occurenceRepository = occurenceRepository;
            _mapper = mapper;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            var users = _repository.FindAll();
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
            if (!_repository.Exists(userId)) return NotFound("User does not exist.");

            var buildings = _buildingRepository.FindAllByCustomerId(userId);
            return Ok(_mapper.Map<IEnumerable<BuildingReadDto>>(buildings));
        }

        [HttpGet("{userId}/occurences")]
        public IActionResult GetOccurences(Guid userId)
        {
            if (!_repository.Exists(userId)) return NotFound("User does not exist.");

            var occurences = _occurenceRepository.FindAllByCustomerId(userId);
            return Ok(_mapper.Map<IEnumerable<OccurenceReadDto>>(occurences));
        }
    }
}
