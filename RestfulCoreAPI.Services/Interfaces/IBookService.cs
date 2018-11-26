using System.Collections.Generic;
using RestfulCoreAPI.Models;
using RestfulCoreAPI.ViewModels;

namespace RestfulCoreAPI.Services.Interfaces
{
    public interface IBookService
    {
        BookViewModel Create(BookViewModel book);
        void Delete(int id);
        IList<BookViewModel> GetAll();
        BookViewModel GetById(int id);
        BookViewModel Update(BookViewModel book);
    }
}