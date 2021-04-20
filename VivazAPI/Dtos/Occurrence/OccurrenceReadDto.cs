using System;

namespace VivazAPI.Dtos
{
    public class OccurrenceReadDto
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid BuildingId { get; set; }
        public Guid ActivityTypeId { get; set; }
        public string Description { get; set; }
    }
}
