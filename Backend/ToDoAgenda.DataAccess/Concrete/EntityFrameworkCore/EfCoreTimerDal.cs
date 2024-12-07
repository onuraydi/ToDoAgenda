using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.DataAccess.EntityFramework;
using ToDoAgenda.DataAccess.Abstract;
using Timer = TODoAgenda.Entities.Concrete.Timer;

namespace ToDoAgenda.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfCoreTimerDal:EfCoreEntityRepositoryBase<Timer,ToDoAgendaContext>, ITimerDal
    {
    }
}
