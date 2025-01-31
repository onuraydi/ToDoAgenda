using Microsoft.EntityFrameworkCore;
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
        private readonly ToDoAgendaContext _context;

        public EfCoreTaskDal()
        {

        }

        public EfCoreTaskDal(ToDoAgendaContext context)
        {
            _context = context;
        }

        public async Task<List<Task>> GetAllWithAllDetail()
        {
            return await _context.Tasks
                .Include(t => t.Timer)
                .Include(t => t.Result)
                .Include(t => t.ImportanceLevel)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
