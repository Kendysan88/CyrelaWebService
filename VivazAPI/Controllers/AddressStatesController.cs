using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VivazAPI.Data;
using VivazAPI.Dtos;
using VivazAPI.Models;

namespace VivazAPI.Controllers
{
    [ApiController]
    [Route("api/address_states")]
    public class AddressStatesController : ControllerBase
    {
        private readonly IRepository<AddressState> _repository;

        private readonly IMapper _mapper;

        public AddressStatesController(IRepository<AddressState> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            var brands = _repository.FindAll();
            return Ok(_mapper.Map<IEnumerable<AddressStateReadDto>>(brands));
        }
    }
}
