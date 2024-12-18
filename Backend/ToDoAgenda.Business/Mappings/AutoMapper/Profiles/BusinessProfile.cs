using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Business.Concrete.Managers.UserManager;
using ToDoAgenda.DataAccess.Abstract.ForEntity;
using TODoAgenda.Entities.Concrete;

namespace ToDoAgenda.Business.Mappings.AutoMapper.Profiles
{
    public class BusinessProfile:Profile
    {
        public BusinessProfile() 
        {
            CreateMap<IUserDal, UserManager>().ReverseMap();   // burası belkide şu şekilde olacak CreateMap<User, UserM>();
        }
    }
}
