using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> FindAllUsers();
        IQueryable<User> FindByRole(string role);

    }
}
