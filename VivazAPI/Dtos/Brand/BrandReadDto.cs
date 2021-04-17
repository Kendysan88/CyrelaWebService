using System;

namespace VivazAPI.Dtos
{
    public class BrandReadDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
