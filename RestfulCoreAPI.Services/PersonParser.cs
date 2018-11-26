using RestfulCoreAPI.Models;
using RestfulCoreAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestfulCoreAPI.Services
{
    // Sometimes Viewmodels can be implemented as VOs (value objects)
    public class PersonParser : IParser<PersonViewModel, Person>, IParser<Person, PersonViewModel>
    {
        public Person Parse(PersonViewModel origin)
        {
            if (origin == null) return new Person();

            return new Person()
            {
                Id = origin.Id,
                FirstName = origin.FirstName,
                LastName = origin.LastName,
                Gender = origin.Gender
            };
        }

        public PersonViewModel Parse(Person origin)
        {
            if (origin == null) return new PersonViewModel();

            return new PersonViewModel()
            {
                Id = origin.Id,
                FirstName = origin.FirstName,
                LastName = origin.LastName,
                Gender = origin.Gender
            };
        }

        public IList<Person> ParseList(IList<PersonViewModel> origin)
        {
            if (origin == null) return new List<Person>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public IList<PersonViewModel> ParseList(IList<Person> origin)
        {
            if (origin == null) return new List<PersonViewModel>();
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
