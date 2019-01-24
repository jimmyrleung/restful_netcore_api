using RestfulCoreAPI.Data.Repositories.Interfaces;
using RestfulCoreAPI.Services.Interfaces;
using RestfulCoreAPI.ViewModels;

namespace RestfulCoreAPI.Services
{
    public class LoginService : ILoginService
    {
        private IUserRepository _userRepository;
        private readonly UserParser _parser;

        public LoginService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _parser = new UserParser();
        }

        public UserViewModel Login(UserViewModel userViewModel)
        {
            return _parser.Parse(_userRepository.FindByUsername(userViewModel.Username));
        }
    }
}
