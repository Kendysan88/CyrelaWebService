using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public class ScheduleRepository : Repository<Schedule>, IScheduleRepository
    {
        public ScheduleRepository(DataContext context) : base(context) { }

        public IEnumerable<Schedule> FindAllWithAssociations()
        {
            return _context.Set<Schedule>()
                .Include(u => u.Employee)
                .Include(o => o.Occurence)
                .AsEnumerable();
        }     

        public Schedule FindByIdWithAssociations(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool IsAnyScheduleAtRange(Guid employeeId, DateTime actualStart, DateTime actualEnd)
        {
            return _context.Set<Schedule>()
                .Where(e => e.EmployeeId == employeeId)
                .Where(e => actualStart.Date <= e.ActualEnd && actualEnd.Date >= e.ActualEnd)
                .Any();
        }
    }
}
