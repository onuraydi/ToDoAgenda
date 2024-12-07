using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Dtos;

namespace ToDoAgenda.DTOLayer.ToDoAgendaDtos.ImportanceLevelDtos
{
    public class GetImportanceLevelByTaskId:IDto
    {
        // görev id'sine göre level'i getirecek
        public int ImpotanceLevelId { get; set; }
        public int ImportanceLevelDegree { get; set; }
        // taskId
    }
}
