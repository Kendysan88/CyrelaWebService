using System;
using System.ComponentModel.DataAnnotations;

namespace VivazAPI.Models
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        // [Required]
        // public DateTime CreatedAt { get; set; }

        // [Required]
        // public DateTime UpdatedAt { get; set; }
    }
}
