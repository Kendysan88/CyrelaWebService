using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VivazAPI.Models;

namespace VivazAPI.Dtos
{
    public class UserReadDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public IList<ScheduleReadDto> Schedules { get; set; }


    }
}
