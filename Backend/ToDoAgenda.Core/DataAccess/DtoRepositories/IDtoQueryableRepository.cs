using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Dtos;
using ToDoAgenda.Core.Entities;

namespace ToDoAgenda.Core.DataAccess.DtoRepositories
{
    public interface IDtoQueryableRepository<T> where T : class, IDto, new()
    {
        IQueryable<T> Table { get; }
    }
}
