using System;
using System.ComponentModel.DataAnnotations;

namespace VivazAPI.Dtos
{
    public class ScheduleUpdateDto
    {
        //Employee
        [Required]
        public Guid EmployeeId { get; set; }
        //Occurence
        [Required]
        public DateTime ActualStart { get; set; }
        [Required]
        public DateTime ActualEnd { get; set; }
    }
}
