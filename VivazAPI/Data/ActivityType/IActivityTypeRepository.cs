using System.Linq;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public interface IActivityTypeRepository : IRepository<ActivityType>
    {
        IQueryable<ActivityType> FindByWarranty(int warranty);
    }
}
