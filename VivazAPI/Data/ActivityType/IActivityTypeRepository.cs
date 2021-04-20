using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public interface IActivityTypeRepository : IRepository<ActivityType>
    {
        IQueryable<ActivityType> FindByWarranty(int warranty);
    }
}
  