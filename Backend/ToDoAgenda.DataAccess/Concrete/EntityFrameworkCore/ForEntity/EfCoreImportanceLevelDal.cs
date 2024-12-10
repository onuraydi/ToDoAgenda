using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.DataAccess.EntityFrameworkCore.ForEntity;
using ToDoAgenda.DataAccess.Abstract.ForEntity;
using TODoAgenda.Entities.Concrete;

namespace ToDoAgenda.DataAccess.Concrete.EntityFrameworkCore.ForEntity
{
    public class EfCoreImportanceLevelDal : EfCoreEntityRepositoryBase<ImportanceLevel, ToDoAgendaContext>, IImportanceLevelDal
    {
    }
}
