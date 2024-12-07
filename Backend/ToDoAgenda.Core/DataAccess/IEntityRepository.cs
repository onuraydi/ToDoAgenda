using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Entities;

namespace ToDoAgenda.Core.DataAccess
{
    public interface IEntityRepository<T> where T: class, IEntity, new() 
    {
        Task<List<T>> GetAll(Expression<Func<T,bool>> filter = null);
        Task<T> Get(Expression<Func<T, bool>> filter);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task Delete(T entity);

    }
}
