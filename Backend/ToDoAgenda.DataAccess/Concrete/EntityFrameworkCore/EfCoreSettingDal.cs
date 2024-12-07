using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.DataAccess.EntityFramework;
using ToDoAgenda.DataAccess.Abstract;
using TODoAgenda.Entities.Concrete;

namespace ToDoAgenda.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfCoreSettingDal:EfCoreEntityRepositoryBase<Setting,ToDoAgendaContext>, ISettingDal
    {
    }
}
