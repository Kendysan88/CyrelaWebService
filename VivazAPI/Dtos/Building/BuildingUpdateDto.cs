using System;
using System.ComponentModel.DataAnnotations;

namespace VivazAPI.Dtos
{
    public class BuildingUpdateDto
    {
        [Required]
        public DateTime InspectionDate { get; set; } = DateTime.Now;
    }
}
