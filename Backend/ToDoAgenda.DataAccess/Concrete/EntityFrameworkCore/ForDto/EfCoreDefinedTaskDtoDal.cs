using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.DataAccess.EntityFrameworkCore.ForDto;
using ToDoAgenda.DataAccess.Abstract.ForDto;
using ToDoAgenda.DTOLayer.ToDoAgendaDtos.DefinedTaskDtos;

namespace ToDoAgenda.DataAccess.Concrete.EntityFrameworkCore.ForDto
{
    public class EfCoreDefinedTaskDtoDal:EfCoreDtoRepositoryBase<DefinedTaskDto,ToDoAgendaContext>,IDefinedTaskDtoDal
    {
    }
}
