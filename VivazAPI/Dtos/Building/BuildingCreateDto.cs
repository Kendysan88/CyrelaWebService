using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VivazAPI.Dtos
{
    public class BuildingCreateDto
    {
        // Customer
        [Required]
        public Guid CustomerId { get; set; }

        // Brand
        [Required]
        public Guid BrandId { get; set; }

        // Address
        [Required]
        public string AddressStreet { get; set; }

        [Required]
        public string AddressNumber { get; set; }

        [Required]
        public string AddressPostalCode { get; set; }

        [Required]
        public string AddressNeighborhood { get; set; }

        [Required]
        public string AddressCity { get; set; }

        [Required]
        public Guid AddressStateId { get; set; }

        public DateTime? InspectionDate { get; set; }
    }
}
