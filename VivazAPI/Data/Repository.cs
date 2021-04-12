using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private DataContext _context { get; }
        private DbSet<T> dataset;

        public Repository(DataContext context)
        {
            _context = context;
            dataset = _context.Set<T>();
        }

        public IEnumerable<T> FindAll()
        {
            return dataset.AsEnumerable();
        }

        public T FindById(Guid id)
        {
            return dataset.SingleOrDefault(p => p.Id.Equals(id));
        }

        public T Create(T entity)
        {
            try
            {
                dataset.Add(entity);
                _context.SaveChanges();

                return entity;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public T Update(T entity)
        {
            try
            {
                dataset.Update(entity);
                _context.SaveChanges();

                return entity;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public void Delete(T entity)
        {
            try
            {
                dataset.Remove(entity);
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}