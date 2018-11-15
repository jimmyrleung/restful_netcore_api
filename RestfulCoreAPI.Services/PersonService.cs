using System;
using System.Collections.Generic;
using System.Text;
using RestfulCoreAPI.Data.Repositories;
using RestfulCoreAPI.Data.Repositories.Interfaces;
using RestfulCoreAPI.Models;
using RestfulCoreAPI.Services.Interfaces;

namespace RestfulCoreAPI.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public Person Create(Person person)
        {
            return _personRepository.Create(person);
        }

        public void Delete(int id)
        {
            _personRepository.Delete(id);
        }

        public IList<Person> GetAll()
        {
            return _personRepository.GetAll();
        }

        public Person GetById(int id)
        {
            return _personRepository.GetbyId(id);
        }

        public Person Update(Person person)
        {
            return _personRepository.Update(person);
        }
    }
}
