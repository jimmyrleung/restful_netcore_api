using System;
using System.Collections.Generic;
using System.Text;
using RestfulCoreAPI.Data.Repositories;
using RestfulCoreAPI.Data.Repositories.Interfaces;
using RestfulCoreAPI.Models;
using RestfulCoreAPI.Services.Interfaces;
using RestfulCoreAPI.ViewModels;

namespace RestfulCoreAPI.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly PersonParser _parser;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
            _parser = new PersonParser();
        }

        public PersonViewModel Create(PersonViewModel personViewModel)
        {
            var person = _parser.Parse(personViewModel);
            person =_personRepository.Create(person);
            return _parser.Parse(person);
        }

        public void Delete(int id)
        {
            _personRepository.Delete(id);
        }

        public IList<PersonViewModel> GetAll()
        {
            return _parser.ParseList(_personRepository.GetAll());
        }

        public PersonViewModel GetById(int id)
        {
            return _parser.Parse(_personRepository.GetbyId(id));
        }

        public PersonViewModel Update(PersonViewModel personViewModel)
        {
            var person = _parser.Parse(personViewModel);
            person = _personRepository.Update(person);
            return _parser.Parse(person);
        }
    }
}
