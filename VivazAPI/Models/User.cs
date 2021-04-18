using System.ComponentModel.DataAnnotations;

namespace VivazAPI.Models
{
    public class User : BaseEntity
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        // TODO: use enum
        [Required]
        public string Role { get; set; }
    }
}
