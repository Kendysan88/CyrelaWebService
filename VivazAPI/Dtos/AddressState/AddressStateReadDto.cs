using System;

namespace VivazAPI.Dtos
{
    public class AddressStateReadDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Uf { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
