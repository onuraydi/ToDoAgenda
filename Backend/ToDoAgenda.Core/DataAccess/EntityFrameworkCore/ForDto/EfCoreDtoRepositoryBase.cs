using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.DataAccess.DtoRepositories;
using ToDoAgenda.Core.Dtos;

namespace ToDoAgenda.Core.DataAccess.EntityFrameworkCore.ForDto
{
    public class EfCoreDtoRepositoryBase<TDto, TContext> : IDtoRepository<TDto> where TDto : class, IDto, new() where TContext : DbContext, new()
    {
        public async Task<TDto> Add(TDto dto)
        {
            await using (var context = new TContext())
            {
                var addedDto = await context.AddAsync(dto);
                await context.SaveChangesAsync();
                return dto;
            }
        }

        public async Task Delete(TDto dto)
        {
            await using (var context = new TContext())
            {
                var deletedDto = context.Remove(dto);
                await context.SaveChangesAsync();
            }
        }

        public async Task<TDto> Get(Expression<Func<TDto, bool>> filter)
        {
            await using (var context = new TContext())
            {
                var values = await context.Set<TDto>().SingleOrDefaultAsync(filter);
                return values;
            }
        }

        public async Task<List<TDto>> GetAll(Expression<Func<TDto, bool>> filter = null)
        {
            await using (var context = new TContext())
            {
                return filter == null
                    ? await context.Set<TDto>().ToListAsync()
                    : await context.Set<TDto>().Where(filter).ToListAsync();
            }
        }

        public async Task<TDto> Update(TDto dto)
        {
            await using (var context = new TContext())
            {
                var updatedDto = context.Update(dto);
                await context.SaveChangesAsync();
                return dto;
            }
        }
    }
}
