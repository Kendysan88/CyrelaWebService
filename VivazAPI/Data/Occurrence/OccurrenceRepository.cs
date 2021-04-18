using System;
using System.Collections.Generic;
using System.Linq;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public class OccurrenceRepository : Repository<Occurrence>, IOccurrenceRepository
    {
        public OccurrenceRepository(DataContext context) : base(context) { }

        public IEnumerable<Occurrence> FindAllByCustomerId(Guid id)
        {
            return _context.Set<Occurrence>().Where(e => e.CustomerId == id);
        }
    }
}
