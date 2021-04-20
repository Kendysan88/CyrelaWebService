using System;
using System.Collections.Generic;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public interface IBuildingRepository : IRepository<Building>
    {
        IEnumerable<Building> FindAllByCustomerId(Guid id);
        IEnumerable<Building> FindAllWithAssociations();
        Building FindByIdWithAssociations(Guid id);
    }
}
