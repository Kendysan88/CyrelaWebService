using System;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public interface IScheduleRepository :IRepository<Schedule>
    {
        bool IsAnyScheduleAtRange(Guid employeeId, DateTime actualStart, DateTime actualEnd);
    }
}
