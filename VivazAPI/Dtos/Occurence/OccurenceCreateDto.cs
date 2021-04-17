using System;
using System.ComponentModel.DataAnnotations;

namespace VivazAPI.Dtos
{
    public class OccurenceCreateDto
    {
        // Customer
        [Required]
        public Guid CustomerId { get; set; }

        // Building
        [Required]
        public Guid BuildingId { get; set; }

        // Activity Type
        [Required]
        public Guid ActivityId { get; set; }

        public string Description { get; set; }
    }
}
