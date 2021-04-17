using System;
using System.ComponentModel.DataAnnotations;

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
    }
}
