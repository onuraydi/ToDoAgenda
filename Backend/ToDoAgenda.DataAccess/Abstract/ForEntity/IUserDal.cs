using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.DataAccess.EntityRepositories;
using TODoAgenda.Entities.Concrete;

namespace ToDoAgenda.DataAccess.Abstract.ForEntity
{
    public interface IUserDal : IEntityRepository<User>
    {
    }
}
