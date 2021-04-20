using System;
using System.ComponentModel.DataAnnotations;

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
