using System;

namespace VivazAPI.Dtos
{
    public class OccurrenceWithDetailsReadDto
    {
        public Guid Id { get; set; }
        public UserReadDto Customer { get; set; }
        public BuildingReadDto Building { get; set; }
        public ActivityTypeReadDto ActivityType { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
