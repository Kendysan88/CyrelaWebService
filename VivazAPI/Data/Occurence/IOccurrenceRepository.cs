using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivazAPI.Models;

namespace VivazAPI.Data.Occurence
{
    public interface IOccurrenceRepository : IRepository<Occurrence>
    {
        IEnumerable<Occurrence> FindAllByCustomerId(Guid id);
        IEnumerable<Occurrence> FindAllWithAssociations();
        Occurrence FindByIdWithAssociations(Guid id);
    }
}
