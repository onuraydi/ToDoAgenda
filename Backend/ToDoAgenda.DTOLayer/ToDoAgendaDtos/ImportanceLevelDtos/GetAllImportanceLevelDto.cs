using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Dtos;

namespace ToDoAgenda.DTOLayer.ToDoAgendaDtos.ImportanceLevelDtos
{
    public class GetAllImportanceLevelDto:IDto
    {
        // önem seviyelerinin derecesini getirecek 1,2,3,4,5
        public int ImpotanceLevelId { get; set; }
        public int ImportanceLevelDegree { get; set; }
    }
}
