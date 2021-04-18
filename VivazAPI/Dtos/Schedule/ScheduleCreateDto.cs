using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VivazAPI.Dtos
{
    public class ScheduleCreateDto
    {
        public Guid Id { get; set; }
        //Employee
        public UserReadDto Employee { get; set; }
        //Occurence
        public Guid OccurenceId { get; set; }
        public OccurrenceWithDetailsReadDto Occurence { get; set; }
        public DateTime ActualStart { get; set; }
        public DateTime ActualEnd { get; set; }
    }
}
