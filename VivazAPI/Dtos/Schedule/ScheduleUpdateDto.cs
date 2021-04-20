using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
