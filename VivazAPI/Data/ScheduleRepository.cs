using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public class ScheduleRepository<T> : IRepository<T> where T : BaseEntity
    {
        private DataContext _context { get; }
        private DbSet<T> _dataset;

        public ScheduleRepository(DataContext context)
        {
            _context = context;
            _dataset = _context.Set<T>();
        }
        public void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _dataset.Add(entity);
        }

        public void Delete(T entity)
        {
            _dataset.Remove(entity);
        }

        public IEnumerable<T> FindAll()
        {
            return _dataset.ToList();
        }

        public T FindById(Guid id)
        {
            return _dataset.SingleOrDefault(p => p.Id.Equals(id));
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
