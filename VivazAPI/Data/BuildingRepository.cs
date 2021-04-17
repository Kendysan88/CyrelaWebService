using System;
using System.Collections.Generic;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public class BuildingRepository : Repository<Building>, IBuildingRepository
    {
        public BuildingRepository(DataContext context) : base(context) { }

        public IEnumerable<Building> FindAllByUserId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}