using System;

namespace VivazAPI.Dtos
{
    public class ScheduleReadDto
    {
        public Guid Id { get; set; }
        //Employee
        public Guid EmployeeId { get; set; }
        //Occurence
        public Guid OccurenceId { get; set; }
        public DateTime ActualStart { get; set; }
        public DateTime ActualEnd { get; set; }
    }
}
