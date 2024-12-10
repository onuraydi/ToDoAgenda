using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Dtos;

namespace ToDoAgenda.Core.DataAccess.DtoRepositories
{
    public interface IDtoRepository<T> where T : class, IDto, new()
    {
        Task<List<T>> GetAll(Expression<Func<T, bool>> filter = null);
        Task<T> Get(Expression<Func<T, bool>> filter);
        Task<T> Add(T dto);
        Task<T> Update(T dto);
        Task Delete(T dto);
    }
}
