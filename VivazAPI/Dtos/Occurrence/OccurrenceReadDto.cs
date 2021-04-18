using System;

namespace VivazAPI.Dtos
{
    public class OccurrenceReadDto
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid BuildingId { get; set; }
        public Guid ActivityId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
