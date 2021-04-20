using System;
using System.ComponentModel.DataAnnotations;

namespace VivazAPI.Models
{
    public class Building : BaseEntity
    {
        // Customer
        [Required]
        public Guid CustomerId { get; set; }

        public User Customer { get; set; }

        // Brand
        [Required]
        public Guid BrandId { get; set; }

        public Brand Brand { get; set; }

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

        public AddressState AddressState { get; set; }

        public DateTime InspectionDate { get; set; }
  }
}