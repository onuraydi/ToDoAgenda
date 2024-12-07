using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Dtos;

namespace ToDoAgenda.DTOLayer.ToDoAgendaDtos.ImportanceLevelDtos
{
    public class GetImportanceLevelByImportanceLevelId:IDto
    {
        public int ImpotanceLevelId { get; set; }
        public int ImportanceLevelDegree { get; set; }
    }
}
