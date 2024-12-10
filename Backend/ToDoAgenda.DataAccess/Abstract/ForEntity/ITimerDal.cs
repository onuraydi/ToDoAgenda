using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.DataAccess.EntityRepositories;
using TODoAgenda.Entities.Concrete;
using Timer = TODoAgenda.Entities.Concrete.Timer;

namespace ToDoAgenda.DataAccess.Abstract.ForEntity
{
    public interface ITimerDal : IEntityRepository<Timer>
    {
    }
}
