using System;
using System.ComponentModel.DataAnnotations;

namespace VivazAPI.Dtos
{
    public class OccurrenceUpdateDto
    {
        // Building
        [Required]
        public Guid BuildingId { get; set; }

        // Activity Type
        [Required]
        public Guid ActivityId { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
