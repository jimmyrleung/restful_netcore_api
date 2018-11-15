using RestfulCoreAPI.Models;
using System.Collections.Generic;

namespace RestfulCoreAPI.Services.Interfaces
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person GetById(int id);
        IList<Person> GetAll();
        Person Update(Person person);
        void Delete(int id);
    }
}
