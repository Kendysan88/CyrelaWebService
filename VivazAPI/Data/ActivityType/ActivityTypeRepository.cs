using System.Collections.Generic;
using System.Linq;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public class ActivityTypeRepository : Repository<ActivityType>, IActivityTypeRepository
    {
        public ActivityTypeRepository(DataContext context) : base(context) { }

        public new IEnumerable<ActivityType> FindAll()
        {
            return _context.Set<ActivityType>().ToList();
        }
        public IQueryable<ActivityType> FindByWarranty(int warranty)
        {
            return _context.Set<ActivityType>().Where(x => x.WarrantyInYears == warranty);
        }
    }
}
