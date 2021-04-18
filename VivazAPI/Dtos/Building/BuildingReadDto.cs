using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VivazAPI.Dtos
{
    public class BuildingReadDto
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid BrandId { get; set; }
        public string AddressStreet { get; set; }
        public string AddressNumber { get; set; }
        public string AddressPostalCode { get; set; }
        public string AddressNeighborhood { get; set; }
        public string AddressCity { get; set; }
        public Guid AddressStateId { get; set; }
        public DateTime InspectionDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
