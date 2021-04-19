using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VivazAPI.Dtos
{
    public class ScheduleCreateDto
    {
        //Employee
        [Required]
        public Guid EmployeeId { get; set; }

        //Occurence
        [Required]
        public Guid OccurenceId { get; set; }

        public DateTime? ActualStart { get; set; }

        public DateTime? ActualEnd { get; set; }
    }
}
