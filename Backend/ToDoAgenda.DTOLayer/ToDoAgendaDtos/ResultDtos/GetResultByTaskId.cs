using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Dtos;

namespace ToDoAgenda.DTOLayer.ToDoAgendaDtos.ResultDtos
{
    // göreve göre sonuç getirme
    public class GetResultByTaskId:IDto
    {
        public int ResultId { get; set; }
        public string ResultType { get; set; }  // string değiştirilecek ya da burası kaldırılacak
        public int TrueCount { get; set; }
        public int FalseCount { get; set; }
        public double TotalNetCount { get; set; }
        // taskId
    }
}
