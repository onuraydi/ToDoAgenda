using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.DataAccess.EntityFrameworkCore.ForDto;
using ToDoAgenda.DataAccess.Abstract.ForDto;
using ToDoAgenda.DTOLayer.ToDoAgendaDtos.TaskDtos;

namespace ToDoAgenda.DataAccess.Concrete.EntityFrameworkCore.ForDto
{
    public class EfCoreTaskDtoDal:EfCoreDtoRepositoryBase<TaskDto,ToDoAgendaContext>,ITaskDtoDal
    {
    }
}
