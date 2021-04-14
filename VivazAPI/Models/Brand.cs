using System;
using System.ComponentModel.DataAnnotations;

namespace VivazAPI.Models
{
    public class Brand
    {
        [Key]
        public Guid Id { get; set; }
        // TODO: use enum
        [Required]
        public string Title { get; set; }
    }
}
