using RestfulCoreAPI.Models;

namespace RestfulCoreAPI.Data.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User FindByUsername(string login);
    }
}