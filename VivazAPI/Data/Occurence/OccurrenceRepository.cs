using Microsoft.EntityFrameworkCore;
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
            return _context.Set<Occurrence>()
                .Include(e => e.Building)
                .Include(e => e.Customer)
                .Include(e => e.ActivityType)
                .Where(e => e.CustomerId == id);
        }

        public IEnumerable<Occurrence> FindAllWithAssociations()
        {
            return _context.Set<Occurrence>()
                .Include(e => e.Building)
                .Include(e => e.Customer)
                .Include(e => e.ActivityType)
                .AsEnumerable();
        }

        public Occurrence FindByIdWithAssociations(Guid id)
        {
            return _context.Set<Occurrence>()
                .Include(e => e.Building)
                .Include(e => e.Customer)
                .Include(e => e.ActivityType)
                .SingleOrDefault(e => e.Id == id);
        }
    }
}
