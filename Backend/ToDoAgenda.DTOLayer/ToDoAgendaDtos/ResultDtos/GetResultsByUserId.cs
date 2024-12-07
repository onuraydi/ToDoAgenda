using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Dtos;

namespace ToDoAgenda.DTOLayer.ToDoAgendaDtos.ResultDtos
{
    // kullanıcıya göre sonuçLARı getirme
    public class GetResultsByUserId: IDto
    {
        public int ResultId { get; set; }
        public string ResultType { get; set; }  // string değiştirilecek ya da burası kaldırılacak
        public int TrueCount { get; set; }
        public int FalseCount { get; set; }
        public double TotalNetCount { get; set; }
        // userId
    }
}
