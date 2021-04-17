using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public class ActivityTypeRepository<T> : IRepository<T> where T : BaseEntity
    {
        private DataContext _context { get; }
        private DbSet<T> _dataset;

        public ActivityTypeRepository(DataContext context)
        {
            _context = context;
            _dataset = _context.Set<T>();
        }
        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAll()
        {
            return _dataset.ToList();
        }

        public T FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal object FindByWarranty(int garantia)
        {
            return _context.ActivityTypes.Where(x => x.WarrantyInYears == garantia);
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
