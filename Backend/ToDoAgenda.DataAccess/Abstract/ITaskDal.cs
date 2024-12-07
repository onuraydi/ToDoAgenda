using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.DataAccess;
using Task = TODoAgenda.Entities.Concrete.Task;

namespace ToDoAgenda.DataAccess.Abstract
{
    public interface ITaskDal:IEntityRepository<Task>
    {
    }
}
