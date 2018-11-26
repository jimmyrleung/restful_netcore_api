using System.Collections.Generic;
using RestfulCoreAPI.Data.Repositories.Interfaces;
using RestfulCoreAPI.Models;
using RestfulCoreAPI.Services.Interfaces;
using RestfulCoreAPI.ViewModels;

namespace RestfulCoreAPI.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly BookParser _parser;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
            _parser = new BookParser();
        }

        public BookViewModel Create(BookViewModel bookViewModel)
        {
            var book = _parser.Parse(bookViewModel);
            book = _bookRepository.Create(book);
            return _parser.Parse(book);
        }

        public void Delete(int id)
        {
            _bookRepository.Delete(id);
        }

        public IList<BookViewModel> GetAll()
        {
            return _parser.ParseList(_bookRepository.GetAll());
        }

        public BookViewModel GetById(int id)
        {
            return _parser.Parse(_bookRepository.GetbyId(id));
        }

        public BookViewModel Update(BookViewModel bookViewModel)
        {
            var book = _parser.Parse(bookViewModel);
            book = _bookRepository.Update(book);
            return _parser.Parse(book);
        }
    }
}
