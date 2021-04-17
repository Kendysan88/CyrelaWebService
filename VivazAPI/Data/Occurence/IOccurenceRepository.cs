using System;
using System.Collections.Generic;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public interface IOccurenceRepository : IRepository<Occurence>
    {
        IEnumerable<Occurence> FindAllByCustomerId(Guid id);
    }
}
