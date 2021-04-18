﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VivazAPI.Dtos
{
    public class OccurrenceCreateDto
    {
        // Customer
        [Required]
        public Guid CustomerId { get; set; }

        // Building
        [Required]
        public Guid BuildingId { get; set; }

        // Activity Type
        [Required]
        public Guid ActivityTypeId { get; set; }

        public string Description { get; set; }
    }
}
