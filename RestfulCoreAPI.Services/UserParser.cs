using RestfulCoreAPI.Models;
using RestfulCoreAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestfulCoreAPI.Services
{
    public class UserParser : IParser<UserViewModel, User>, IParser<User, UserViewModel>
    {
        public User Parse(UserViewModel origin)
        {
            if (origin == null) return new User();

            return new User()
            {
                Id = origin.Id,
                Username = origin.Username,
                Password = origin.Password
            };
        }

        public UserViewModel Parse(User origin)
        {
            if (origin == null) return new UserViewModel();

            return new UserViewModel()
            {
                Id = origin.Id,
                Username = origin.Username,
                Password = origin.Password
            };
        }

        public IList<User> ParseList(IList<UserViewModel> origin)
        {
            if (origin == null) return new List<User>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public IList<UserViewModel> ParseList(IList<User> origin)
        {
            if (origin == null) return new List<UserViewModel>();
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
