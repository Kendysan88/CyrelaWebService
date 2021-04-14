using System;
using System.ComponentModel.DataAnnotations;

namespace VivazAPI.Models
{
    public class ActivityType
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Description { get; set; }

        [Required]
        public int WarrantyInYears { get; set; }
    }
}
