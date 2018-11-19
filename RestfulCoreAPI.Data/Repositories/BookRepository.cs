using RestfulCoreAPI.Data.Repositories.Interfaces;
using RestfulCoreAPI.Models;

namespace RestfulCoreAPI.Data.Repositories
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        private MySQLContext _context;

        public BookRepository(MySQLContext context): base(context)
        {
            _context = context;
        }
    }
}