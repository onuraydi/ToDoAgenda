using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.DataAccess.EntityFrameworkCore.ForEntity;
using ToDoAgenda.DataAccess.Abstract.ForEntity;
using Task = TODoAgenda.Entities.Concrete.Task;

namespace ToDoAgenda.DataAccess.Concrete.EntityFrameworkCore.ForEntity
{
    public class EfCoreTaskDal : EfCoreEntityRepositoryBase<Task, ToDoAgendaContext>, ITaskDal
    {
    }
}
