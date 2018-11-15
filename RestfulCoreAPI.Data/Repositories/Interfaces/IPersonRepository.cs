using RestfulCoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestfulCoreAPI.Data.Repositories.Interfaces
{
    public interface IPersonRepository
    {
        Person Create(Person entity);

        Person Update(Person entity);

        Person GetbyId(int id);

        IList<Person> GetAll();

        void Delete(int id);
    }
}
