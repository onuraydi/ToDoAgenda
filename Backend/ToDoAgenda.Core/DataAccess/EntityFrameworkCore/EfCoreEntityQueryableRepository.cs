using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Entities;

namespace ToDoAgenda.Core.DataAccess.EntityFramework
{
    public class EfCoreEntityQueryableRepository<T> : IEntityQueryableRepository<T> where T : class, IEntity, new()
    {
        private readonly DbContext _dbContext;
        private DbSet<T> _entities;    // Burada bir hata olabilir

        public EfCoreEntityQueryableRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> Table => this.Entities;

        protected virtual DbSet<T> Entities
        {
            get
            {
                if(_entities == null)
                {
                    _entities = _dbContext.Set<T>();
                }
                return _entities;
            }
        }
    }
}
