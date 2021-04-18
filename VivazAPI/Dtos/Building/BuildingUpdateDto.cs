using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VivazAPI.Dtos
{
    public class BuildingUpdateDto
    {
        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [Required]
        public DateTime InspectionDate { get; set; } = DateTime.Now;
    }
}
