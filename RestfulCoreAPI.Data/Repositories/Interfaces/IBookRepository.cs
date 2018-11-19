using RestfulCoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestfulCoreAPI.Data.Repositories.Interfaces
{
    public interface IBookRepository
    {
        Book Create(Book entity);

        Book Update(Book entity);

        Book GetbyId(int id);

        IList<Book> GetAll();

        void Delete(int id);
    }
}
