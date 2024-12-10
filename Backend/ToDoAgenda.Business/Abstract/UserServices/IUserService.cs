using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODoAgenda.Entities.Concrete;

namespace ToDoAgenda.Business.Abstract.UserServices
{
    public interface IUserService
    {
        Task<List<User>> GetAll();
        Task<User> GetById(int id);
        Task<User> GetByName(string name);
        Task<User> GetBySurname(string surname);
        Task<User> GetByEmail(string email);
        Task<User> Add(User user);
        Task<User> Update(User user);

        // silme sonra eklenebilir kullanıcı silmek çok istenen birşey değil
    }
}
