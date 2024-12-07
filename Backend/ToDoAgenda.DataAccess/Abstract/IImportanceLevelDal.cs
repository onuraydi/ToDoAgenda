using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.DataAccess;
using TODoAgenda.Entities.Concrete;

namespace ToDoAgenda.DataAccess.Abstract
{
    public interface IImportanceLevelDal:IEntityRepository<ImportanceLevel>
    {
    }
}
