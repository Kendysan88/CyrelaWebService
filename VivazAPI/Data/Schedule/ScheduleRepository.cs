using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public class ScheduleRepository : Repository<Schedule>, IScheduleRepository
    {
        public ScheduleRepository(DataContext context) : base(context) { }

        public Schedule FindByIdWithAssociations(Guid id)
        {
            return _context.Set<Schedule>()
                .Include(e => e.Employee)
                .Include(e => e.Occurence)
                .SingleOrDefault(e => e.Id == id);
        }

        public IEnumerable<Schedule> FindAllWithAssociations()
        {
            return _context.Set<Schedule>()
                .Include(e => e.Employee)
                .Include(e => e.Occurence)
                .AsEnumerable();
        }

        public bool IsAnyScheduleAtRange(Guid employeeId, DateTime actualStart, DateTime actualEnd)
        {
            return _context.Set<Schedule>()
                .Where(e => e.EmployeeId == employeeId)
                .Where(e => actualStart.Date <= e.ActualEnd.Date && actualEnd.Date >= e.ActualEnd.Date)
                .Any();
        }
    }
}
