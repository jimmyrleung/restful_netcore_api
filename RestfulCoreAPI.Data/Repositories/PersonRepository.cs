using RestfulCoreAPI.Data.Repositories.Interfaces;
using RestfulCoreAPI.Models;
using System;

namespace RestfulCoreAPI.Data.Repositories
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        private MySQLContext _context;

        public PersonRepository(MySQLContext context): base(context)
        {
            _context = context;
        }
    }
}
