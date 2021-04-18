using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DataContext context) : base(context) { }

        public new IEnumerable<User> FindAll()
        {
            return _context.Set<User>().ToList();
        }

        public IQueryable<User> FindByRole(string role)
        {
            return _context.Set<User>().Where(x => x.Role.Contains(role));
        }
    }
}
