using System;
using System.Collections.Generic;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> FindAll();
        T FindById(Guid id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        bool Exists(Guid id);
        bool SaveChanges();
    }
}