using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VivazAPI.Data;
using VivazAPI.Models;

namespace VivazAPI.Controllers
{
    [Route("api/address_states")]
    [ApiController]
    public class AddressStatesController : ControllerBase
    {
        private readonly IRepository<AddressState> _repository;

        public AddressStatesController(IRepository<AddressState> repository)
        {
            _repository = repository;
        }

        // GET: api/AddressStates
        [HttpGet]
        public ActionResult<IEnumerable<AddressState>> GetAddressStates()
        {
            var userItem = _repository.FindAll();
            return Ok(userItem);
        }       
    }
}
