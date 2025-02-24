using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Dtos;

namespace ToDoAgenda.DTOLayer.ToDoAgendaDtos.ImportanceLevelDtos
{
    public class ImportanceLevelWithoutIdDto:IDto
    {
        public ImportanceDegree importanceLevelDegree { get; set; }
    }
}
