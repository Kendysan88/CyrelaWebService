using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using VivazAPI.Data;
using VivazAPI.Data.Occurence;
using VivazAPI.Domain;
using VivazAPI.Dtos;
using VivazAPI.Models;

namespace VivazAPI.Controllers
{
    [ApiController]
    [Route("api/occurrences")]
    public class OccurrencesController : ControllerBase
    {
        private readonly IOccurrenceRepository _repository;
        private readonly IRepository<ActivityType> _repositoryActivityType;
        private readonly IRepository<Building> _repositoryBuilding;
        private readonly IOccurrenceInWarranty _warrantyValidator;
        private readonly IMapper _mapper;
        public OccurrencesController(
            IOccurrenceRepository repository,
            IRepository<ActivityType> repositoryActivityType,
            IRepository<Building> repositoryBuilding,
            IOccurrenceInWarranty warrantyValidator,
            IMapper mapper
        )
        {
            _repository = repository;
            _repositoryActivityType = repositoryActivityType;
            _repositoryBuilding = repositoryBuilding;
            _warrantyValidator = warrantyValidator;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<OccurrenceWithDetailsReadDto>> Get()

        {
            var occurrences = _repository.FindAllWithAssociations();
            return Ok(_mapper.Map<IEnumerable<OccurrenceWithDetailsReadDto>>(occurrences));
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var occurrence = _repository.FindByIdWithAssociations(id);

            if (occurrence != null)
            {
                return Ok(_mapper.Map<OccurrenceWithDetailsReadDto>(occurrence));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Post(OccurrenceCreateDto occurrenceCreateDto)
        {
            var occurrenceModel = _mapper.Map<Occurrence>(occurrenceCreateDto);
            var building = _repositoryBuilding.FindById(occurrenceModel.BuildingId);
            var activityType = _repositoryActivityType.FindById(occurrenceModel.ActivityTypeId);

            if (building == null || activityType == null) return NotFound();

            if (_warrantyValidator.IsOccurreceInWarranty(activityType.WarrantyInYears, building.InspectionDate))
            {
                return UnprocessableEntity("Este tipo de atividade não é mais aplicável à essa construção (prazo de validade).");
            }

            _repository.Create(occurrenceModel);

            if (_repository.SaveChanges())
            {
                return Ok(_mapper.Map<OccurrenceReadDto>(occurrenceModel));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, OccurrenceUpdateDto occurrenceUpdateDto)
        {
            var occurrence = _repository.FindByIdWithAssociations(id);

            var building = _repositoryBuilding.FindById(occurrence.BuildingId);
            var activityType = _repositoryActivityType.FindById(occurrence.ActivityTypeId);

            if (building == null || activityType == null) return NotFound();

            if (_warrantyValidator.IsOccurreceInWarranty(activityType.WarrantyInYears, building.InspectionDate))
            {
                return UnprocessableEntity("Este tipo de atividade não é mais aplicável à essa construção (prazo de validade).");
            }

            if (occurrence == null) return NotFound();

            _mapper.Map(occurrenceUpdateDto, occurrence);
            _repository.Update(occurrence);

            if (_repository.SaveChanges())
            {
                return Ok(_mapper.Map<OccurrenceReadDto>(occurrence));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var occurrence = _repository.FindById(id);

            if (occurrence == null) return NotFound();

            _repository.Delete(occurrence);

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
