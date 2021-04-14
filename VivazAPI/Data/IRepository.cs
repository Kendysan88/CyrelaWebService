using System;
using System.Collections.Generic;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public interface IRepository<T> where T : BaseEntity
    {
        T FindById(Guid id);
        IEnumerable<T> FindAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        bool SaveChanges();
    }
}