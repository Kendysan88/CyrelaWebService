using System;
using System.ComponentModel.DataAnnotations;

namespace VivazAPI.Dtos
{
    public class UserUpdateDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Role { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
