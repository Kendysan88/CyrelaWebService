using System;
using System.Collections.Generic;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public interface IBuildingRepository : IRepository<Building>
    {
        IEnumerable<Building> FindAllByUserId(Guid id);
    }
}
