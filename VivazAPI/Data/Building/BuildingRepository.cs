using System;
using System.Collections.Generic;
using System.Linq;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public class BuildingRepository : Repository<Building>, IBuildingRepository
    {
        public BuildingRepository(DataContext context) : base(context) { }

        public IEnumerable<Building> FindAllByCustomerId(Guid id)
        {
            return _context.Set<Building>().Where(e => e.CustomerId == id);
        }
    }
}
