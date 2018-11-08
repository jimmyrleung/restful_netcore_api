using RestfulCoreAPI.Models;

namespace RestfulCoreAPI.Data.Repositories.Interfaces
{
    public interface IPersonRepository
    {
        Person Create(Person person);
    }
}