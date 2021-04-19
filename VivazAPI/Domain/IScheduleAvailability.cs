using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivazAPI.Models;

namespace VivazAPI.Domain
{
    public interface IScheduleAvailability
    {
        bool IsDataAvailable(IList<Schedule> schedules, DateTime? actualStart);
    }
}
