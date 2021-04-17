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
    [Route("api/occurences")]
    public class OccurencesController : ControllerBase
    {
        private readonly IRepository<Occurence> _repository;

        public readonly IMapper _mapper;

        public OccurencesController(IRepository<Occurence> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var occurences = _repository.FindAll();
            return Ok(_mapper.Map<IEnumerable<OccurenceReadDto>>(occurences));
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var occurence = _repository.FindById(id);

            if (occurence != null)
            {
                return Ok(_mapper.Map<OccurenceReadDto>(occurence));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Post(OccurenceCreateDto occurenceCreateDto)
        {
            var occurenceModel = _mapper.Map<Occurence>(occurenceCreateDto);

            _repository.Create(occurenceModel);

            if (_repository.SaveChanges())
            {
                return Ok(_mapper.Map<OccurenceReadDto>(occurenceModel));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, OccurenceUpdateDto occurenceUpdateDto)
        {
            var occurence = _repository.FindById(id);

            if (occurence == null) return NotFound();

            _mapper.Map(occurenceUpdateDto, occurence);
            _repository.Update(occurence);

            if (_repository.SaveChanges())
            {
                return Ok(_mapper.Map<OccurenceReadDto>(occurence));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var occurence = _repository.FindById(id);
            Console.WriteLine(occurence);

            if (occurence == null) return NotFound();

            _repository.Delete(occurence);

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
