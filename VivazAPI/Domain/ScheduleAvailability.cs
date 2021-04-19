using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivazAPI.Models;

namespace VivazAPI.Domain
{
    public class ScheduleAvailability : IScheduleAvailability
    {
        public bool IsDataAvailable(IList<Schedule> schedules, DateTime? actualStart)
        {
            var schedule = schedules.Select(x => x.ActualStart);
            if (schedule.Contains(actualStart))
            {
                return true;
            }
            else
            {
                return false;
            }

        } 
    }
}
