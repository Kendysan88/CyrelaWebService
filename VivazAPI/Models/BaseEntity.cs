using System;
using System.ComponentModel.DataAnnotations;

namespace VivazAPI.Models
{
    public class BaseEntity : IEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
