using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VivazAPI.Dtos
{
    public class AddressStateReadDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Uf { get; set; }
    }
}
