using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VivazAPI.Data;
using VivazAPI.Models;
using VivazAPI.Dtos;

namespace VivazAPI.Controllers
{
    [ApiController]
    [Route("api/buildings")]
    public class BuildingsController : ControllerBase
    {
        private readonly IRepository<Building> _repository;

        private readonly IMapper _mapper;

        public BuildingsController(IRepository<Building> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            var buildings = _repository.FindAll();
            return Ok(_mapper.Map<IEnumerable<BuildingReadDto>>(buildings));
        }

        [HttpPost]
        public IActionResult Post(BuildingCreateDto buildingCreateDto)
        {
            var buildingModel = _mapper.Map<Building>(buildingCreateDto);

            _repository.Create(buildingModel);

            if (_repository.SaveChanges())
            {
                return Ok(_mapper.Map<BuildingReadDto>(buildingModel));
            }
            else
            {
                return BadRequest();
            }

        }
    }
}
