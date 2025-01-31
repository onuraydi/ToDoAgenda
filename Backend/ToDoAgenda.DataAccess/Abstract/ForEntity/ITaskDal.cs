using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.DataAccess.EntityRepositories;
using Task = TODoAgenda.Entities.Concrete.Task;

namespace ToDoAgenda.DataAccess.Abstract.ForEntity
{
    public interface ITaskDal : IEntityRepository<Task>
    {
        Task<List<Task>> GetAllWithAllDetail();
        Task<Task> GetWithAllDetail(Expression<Func<Task, bool>> filter);
    }
}
