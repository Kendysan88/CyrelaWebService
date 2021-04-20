using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using VivazAPI.Data;
using VivazAPI.Dtos;
using VivazAPI.Models;

namespace VivazAPI.Controllers
{
    [ApiController]
    [Route("api/buildings")]
    public class BuildingsController : ControllerBase
    {
        private readonly IBuildingRepository _repository;

        private readonly IMapper _mapper;

        public BuildingsController(IBuildingRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            var buildings = _repository.FindAllWithAssociations();
            return Ok(_mapper.Map<IEnumerable<BuildingWithDetailsReadDto>>(buildings));
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var building = _repository.FindByIdWithAssociations(id);

            if (building != null)
            {
                return Ok(_mapper.Map<BuildingWithDetailsReadDto>(building));
            }
            else
            {
                return NotFound();
            }
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

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, BuildingUpdateDto buildingUpdateDto)
        {
            var building = _repository.FindByIdWithAssociations(id);

            if (building == null) return NotFound();

            _mapper.Map(buildingUpdateDto, building);
            _repository.Update(building);

            if (_repository.SaveChanges())
            {
                return Ok(_mapper.Map<BuildingReadDto>(building));
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
