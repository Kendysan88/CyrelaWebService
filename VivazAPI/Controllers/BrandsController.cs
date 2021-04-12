using Microsoft.AspNetCore.Mvc;
using VivazAPI.Data;
using VivazAPI.Models;

namespace VivazAPI.Controllers
{
    [ApiController]
    [Route("api/brands")]
    public class BrandsController : ControllerBase
    {
        private readonly IRepository<Brand> _repository;

        public BrandsController(IRepository<Brand> repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
           return Ok(_repository.FindAll()); 
        }
    }
}