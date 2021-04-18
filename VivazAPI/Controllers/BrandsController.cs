﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivazAPI.Data;
using VivazAPI.Dtos;
using VivazAPI.Models;

namespace VivazAPI.Controllers
{
    [ApiController]
    [Route("api/brands")]
    public class BrandsController : ControllerBase
    {
        private readonly IRepository<Brand> _repository;

        private readonly IMapper _mapper;
        public BrandsController(IRepository<Brand> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Brand>> GetAddressStates()
        {
            var brands = _repository.FindAll();
            return Ok(_mapper.Map<IEnumerable<BrandReadDto>>(brands));
        }
    }
}
