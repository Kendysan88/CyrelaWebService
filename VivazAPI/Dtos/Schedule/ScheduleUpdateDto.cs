using System;
using System.ComponentModel.DataAnnotations;

namespace VivazAPI.Dtos
{
    public class ScheduleUpdateDto
    {
        //User
        [Required]
        public Guid EmployeeId { get; set; }

        [Required]
        public DateTime ActualStart { get; set; }

        [Required]
        public DateTime ActualEnd { get; set; }
    }
}
