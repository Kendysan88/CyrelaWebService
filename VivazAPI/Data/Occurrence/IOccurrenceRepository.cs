using System;
using System.Collections.Generic;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public interface IOccurrenceRepository : IRepository<Occurrence>
    {
        IEnumerable<Occurrence> FindAllByCustomerId(Guid id);
        IEnumerable<Occurrence> FindAllWithAssociations();
        Occurrence FindByIdWithAssociations(Guid id);
    }
}
