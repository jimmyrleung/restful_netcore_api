using RestfulCoreAPI.ViewModels;

namespace RestfulCoreAPI.Services.Interfaces
{
    public interface ILoginService
    {
        UserViewModel Login(UserViewModel userViewModel);
    }
}