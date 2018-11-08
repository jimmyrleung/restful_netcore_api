using RestfulCoreAPI.Models;
using System.Collections.Generic;

namespace RestfulCoreAPI.Services.Interfaces
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
