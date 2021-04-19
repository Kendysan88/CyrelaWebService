using System;
using System.Linq;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public class ScheduleRepository : Repository<Schedule>, IScheduleRepository
    {
        public ScheduleRepository(DataContext context) : base(context) { }

        public bool IsAnyScheduleAtRange(Guid employeeId, DateTime actualStart, DateTime actualEnd)
        {
            return _context.Set<Schedule>()
                .Where(e => e.EmployeeId == employeeId)
                .Where(e => actualStart.Date <= e.ActualEnd.Date && actualEnd.Date >= e.ActualEnd.Date)
                .Any();
        }
    }
}
