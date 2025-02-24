using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Dtos;

namespace ToDoAgenda.DTOLayer.ToDoAgendaDtos.ImportanceLevelDtos
{
    public class ImportanceLevelDto:IDto
    {
        public int importanceLevelId { get; set; }
        public ImportanceDegree importanceLevelDegree { get; set; }
    }
}
