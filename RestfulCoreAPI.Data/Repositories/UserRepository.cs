using RestfulCoreAPI.Data.Repositories.Interfaces;
using RestfulCoreAPI.Models;
using System;
using System.Linq;

namespace RestfulCoreAPI.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private MySQLContext _context;

        public UserRepository(MySQLContext context)
        {
            _context = context;
        }

        public User FindByUsername(string login)
        {
            return _context.User.SingleOrDefault(u => u.username.Equals(login));
        }
    }
}
