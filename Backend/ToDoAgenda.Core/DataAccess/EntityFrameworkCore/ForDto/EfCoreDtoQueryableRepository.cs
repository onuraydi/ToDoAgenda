using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.DataAccess.DtoRepositories;
using ToDoAgenda.Core.Dtos;

namespace ToDoAgenda.Core.DataAccess.EntityFrameworkCore.ForDto
{
    public class EfCoreDtoQueryableRepository<T> : IDtoQueryableRepository<T> where T: class, IDto ,new()
    {
        private readonly DbContext _dbContext;

        private DbSet<T> _dtos;

        public EfCoreDtoQueryableRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> Table => Dtos;
        protected virtual DbSet<T> Dtos  // burayı düzelt ve base'i yaz
        {
            get
            {
                if(_dtos == null)
                {
                    _dtos = _dbContext.Set<T>();
                }
                return _dtos;
            }
        }
        
    }
}
