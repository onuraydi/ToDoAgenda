using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Business.Abstract.UserServices;
using ToDoAgenda.DataAccess.Abstract.ForEntity;
using TODoAgenda.Entities.Concrete;

namespace ToDoAgenda.Business.Concrete.Managers.UserManager
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        private IMapper _mapper;

        public UserManager(IUserDal userDal, IMapper mapper)
        {
            _userDal = userDal;
            _mapper = mapper;
        }

        public async Task<User> Add(User user)
        {
            return await _userDal.Add(user);
        }

        public async Task<List<User>> GetAll()
        {
            var values = await _userDal.GetAll();
            return _mapper.Map<List<User>>(values);
        }

        public async Task<User> GetByEmail(string email)
        {
            return await _userDal.Get(x => x.UserEmail == email);
        }

        public async Task<User> GetById(int id)
        {
            return await _userDal.Get(x => x.UserId == id);
        }

        public async Task<User> GetByName(string name)
        {
            return await _userDal.Get(x => x.UserName == name);
        }

        public async Task<User> GetBySurname(string surname)
        {
            return await _userDal.Get(x => x.UserSurname == surname);
        }

        public async Task<User> Update(User user)
        {
            return await _userDal.Update(user);
        }
    }
}
