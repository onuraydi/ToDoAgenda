using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Entities;

namespace ToDoAgenda.Core.DataAccess.EntityFramework
{
      // Burada async yapı yüzünden hatalar ya da performans kayıpları / artışları yaşanabilir bunu araşştır
    public class EfCoreEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity,new() where TContext : DbContext, new()
    {

        public async Task<TEntity> Add(TEntity entity)
        {
            await using (var context = new TContext())
            {
                var addedEntity = await context.AddAsync(entity);
                await context.SaveChangesAsync();
                return entity;
            }
        }

        public async Task Delete(TEntity entity)
        {
            await using (var context = new TContext())
            {
                var deletedEntity = context.Remove(entity);
                await context.SaveChangesAsync();
            }
        }

        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            await using (var context = new TContext())
            {
                var values = await context.Set<TEntity>().SingleOrDefaultAsync(filter);
                return values;
            }
        }

        public async Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            await using (var context = new TContext())
            {
                return filter == null
                    ? await context.Set<TEntity>().ToListAsync()
                    : await context.Set<TEntity>().Where(filter).ToListAsync();
            }
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            await using (var context = new TContext())
            {
                var updatedEntity = context.Update(entity);
                await context.SaveChangesAsync();
                return entity;
            }
        }
    }
}
