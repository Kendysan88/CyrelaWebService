using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VivazAPI.Data;
using VivazAPI.Models;
using VivazAPI.Dtos;
using System;

namespace VivazAPI.Controllers
{
    [ApiController]
    [Route("api/occurrences")]
    public class OccurrencesController : ControllerBase
    {
        private readonly IOccurrenceRepository _repository;

        public readonly IMapper _mapper;

        public OccurrencesController(IOccurrenceRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
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
