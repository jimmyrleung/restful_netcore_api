using System.Collections.Generic;
using RestfulCoreAPI.Data.Repositories.Interfaces;
using RestfulCoreAPI.Models;
using RestfulCoreAPI.Services.Interfaces;

namespace RestfulCoreAPI.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Book Create(Book book)
        {
            return _bookRepository.Create(book);
        }

        public void Delete(int id)
        {
            _bookRepository.Delete(id);
        }

        public IList<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public Book GetById(int id)
        {
            return _bookRepository.GetbyId(id);
        }

        public Book Update(Book book)
        {
            return _bookRepository.Update(book);
        }
    }
}
