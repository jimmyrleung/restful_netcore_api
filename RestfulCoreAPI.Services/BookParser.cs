using RestfulCoreAPI.Models;
using RestfulCoreAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestfulCoreAPI.Services
{
    // Sometimes Viewmodels can be implemented as VOs (value objects)
    public class BookParser : IParser<BookViewModel, Book>, IParser<Book, BookViewModel>
    {
        public Book Parse(BookViewModel origin)
        {
            if (origin == null) return new Book();

            return new Book()
            {
                Id = origin.Id,
                Author = origin.Author,
                LaunchDate = origin.LaunchDate,
                Price = origin.Price,
                Title = origin.Title
            };
        }

        public BookViewModel Parse(Book origin)
        {
            if (origin == null) return new BookViewModel();

            return new BookViewModel()
            {
                Id = origin.Id,
                Author = origin.Author,
                LaunchDate = origin.LaunchDate,
                Price = origin.Price,
                Title = origin.Title
            };
        }

        public IList<Book> ParseList(IList<BookViewModel> origin)
        {
            if (origin == null) return new List<Book>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public IList<BookViewModel> ParseList(IList<Book> origin)
        {
            if (origin == null) return new List<BookViewModel>();
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
