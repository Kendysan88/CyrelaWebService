using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public interface IScheduleRepository : IRepository<Schedule>
    {
        IEnumerable<Schedule> FindAllWithAssociations();
        Schedule FindByIdWithAssociations(Guid id);
        bool IsAnyScheduleAtRange(Guid employeeId, DateTime actualStart, DateTime actualEnd);
    }
}
