using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VivazAPI.Dtos
{
    public class ScheduleReadDto
    {
        public Guid Id { get; set; }
        //Employee
        public UserReadDto Employee { get; set; }
        //Occurence
        public OccurrenceWithDetailsReadDto Occurence { get; set; }
        public DateTime ActualStart { get; set; }
        public DateTime ActualEnd { get; set; }
    }
}
