using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                .Include(e => e.AddressState)
                .AsEnumerable();
        }

        public Building FindByIdWithAssociations(Guid id)
        {
            return _context.Set<Building>()
                .Include(e => e.Brand)
                .Include(e => e.Customer)
                .Include(e => e.AddressState)
                .SingleOrDefault(e => e.Id == id);
        }

        public IEnumerable<Building> FindAllByCustomerId(Guid id)
        {
            return _context.Set<Building>()
                .Include(e => e.Brand)
                .Include(e => e.Customer)
                .Include(e => e.AddressState)
                .Where(e => e.CustomerId == id);
        }
    }
}
