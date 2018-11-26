using RestfulCoreAPI.Models;
using RestfulCoreAPI.ViewModels;
using System.Collections.Generic;

namespace RestfulCoreAPI.Services.Interfaces
{
    public interface IPersonService
    {
        PersonViewModel Create(PersonViewModel person);
        PersonViewModel GetById(int id);
        IList<PersonViewModel> GetAll();
        PersonViewModel Update(PersonViewModel person);
        void Delete(int id);
    }
}
