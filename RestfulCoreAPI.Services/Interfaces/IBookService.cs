using System.Collections.Generic;
using RestfulCoreAPI.Models;

namespace RestfulCoreAPI.Services.Interfaces
{
    public interface IBookService
    {
        Book Create(Book book);
        void Delete(int id);
        IList<Book> GetAll();
        Book GetById(int id);
        Book Update(Book book);
    }
}