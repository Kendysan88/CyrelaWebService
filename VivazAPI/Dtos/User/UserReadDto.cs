using System;

namespace VivazAPI.Dtos
{
    public class UserReadDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

    }
}
