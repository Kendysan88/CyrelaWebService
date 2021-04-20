using System;
using System.ComponentModel.DataAnnotations;

namespace VivazAPI.Dtos
{
    public class ScheduleCreateDto
    {
        //User
        [Required]
        public Guid EmployeeId { get; set; }

        //Occurence
        [Required]
        public Guid OccurenceId { get; set; }

        [Required]
        public DateTime ActualStart { get; set; }

        [Required]
        public DateTime ActualEnd { get; set; }
    }
}
