using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VivazAPI.Models
{
    public class Occurrence : BaseEntity
    {
        // Customer
        [Required]
        public Guid CustomerId { get; set; }

        public User Customer { get; set; }

        // Building
        [Required]
        public Guid BuildingId { get; set; }

        public Building Building { get; set; }

        // Activity Type
        [Required]
        public Guid ActivityTypeId { get; set; }

        public ActivityType ActivityType { get; set; }

        public string Description { get; set; }
    }
}
