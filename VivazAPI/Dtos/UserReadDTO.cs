using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VivazAPI.Dtos
{
    public class UserReadDTO
    {
        [Required]
        public string Email { get; set; }
        // TODO: use enum
        [Required]
        public string Role { get; set; }
    }
}
