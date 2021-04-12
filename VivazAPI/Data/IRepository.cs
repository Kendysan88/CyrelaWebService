using System;
using System.Collections.Generic;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public interface IRepository<T> where T : BaseEntity
    {
        T FindById(Guid id);
        IEnumerable<T> FindAll();
        T Create(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}