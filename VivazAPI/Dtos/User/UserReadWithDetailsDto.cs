using System;
using System.Collections.Generic;

namespace VivazAPI.Dtos
{
    public class UserReadWithDetailsDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public IList<ScheduleReadDto> Schedules { get; set; }
    }
}
