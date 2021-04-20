using System;

namespace VivazAPI.Dtos
{
    public class ScheduleWithDetailsReadDto
    {
        public Guid Id { get; set; }
        public UserReadDto Employee { get; set; }
        public OccurrenceReadDto Occurence { get; set; }
        public DateTime ActualStart { get; set; }
        public DateTime ActualEnd { get; set; }
    }
}
