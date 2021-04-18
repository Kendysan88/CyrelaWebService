using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public class BuildingRepository : Repository<Building>, IBuildingRepository
    {
        public BuildingRepository(DataContext context) : base(context) { }

        public IEnumerable<Building> FindAllWithAssociations()
        {
            return _context.Set<Building>()
                .Include(e => e.Brand)
                .Include(e => e.Customer)
                .AsEnumerable();
        }

        public Building FindByIdWithAssociations(Guid id)
        {
            return _context.Set<Building>()
                .Include(e => e.Brand)
                .Include(e => e.Customer)
                .SingleOrDefault(e => e.Id == id);
        }

        public IEnumerable<Building> FindAllByCustomerId(Guid id)
        {
            return _context.Set<Building>()
                .Include(e => e.Brand)
                .Include(e => e.Customer)
                .Where(e => e.CustomerId == id);
        }
    }
}
