using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.DataAccess.EntityFrameworkCore.ForEntity;
using ToDoAgenda.DataAccess.Abstract.ForEntity;
using Timer = TODoAgenda.Entities.Concrete.Timer;

namespace ToDoAgenda.DataAccess.Concrete.EntityFrameworkCore.ForEntity
{
    public class EfCoreTimerDal : EfCoreEntityRepositoryBase<Timer, ToDoAgendaContext>, ITimerDal
    {
    }
}
