using System;

namespace VivazAPI.Dtos
{
    public class ActivityTypeReadDto
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int WarrantyInYears { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
