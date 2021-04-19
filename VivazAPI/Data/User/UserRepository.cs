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

        public IEnumerable<User> FindAllUsers()
        {
            return _context.Set<User>()
                .Include(u => u.Schedules)
                .AsEnumerable();
        }       
        public IQueryable<User> FindByRole(string role)
        {
            return _context.Set<User>().Where(x => x.Role.Contains(role));
        }
    }
}
