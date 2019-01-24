using RestfulCoreAPI.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestfulCoreAPI.Services
{
    public class LoginService
    {
        private IUserRepository _userRepository;

        public LoginService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
    }
}
