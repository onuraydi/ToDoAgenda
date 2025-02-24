using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Dtos;

namespace ToDoAgenda.DTOLayer.ToDoAgendaDtos.ResultDtos
{
    public class ResultDto:IDto
    {
        public int resultId { get; set; }
        public int resultTypeId { get; set; }
    }
}
