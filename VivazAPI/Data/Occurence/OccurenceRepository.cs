using System;
using System.Collections.Generic;
using System.Linq;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public class OccurenceRepository : Repository<Occurence>, IOccurenceRepository
    {
        public OccurenceRepository(DataContext context) : base(context) { }

        public IEnumerable<Occurence> FindAllByCustomerId(Guid id)
        {
            return _context.Set<Occurence>().Where(e => e.CustomerId == id);
        }
    }
}
