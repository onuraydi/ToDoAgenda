using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODoAgenda.Entities.Concrete
{
    public class Result
    {
        public int ResultId { get; set; }
        public string ResultType { get; set; }  // string değiştirilecek ya da burası kaldırılacak
        public int TrueCount { get; set; }
        public int FalseCount { get; set; }
        public double TotalNetCount { get; set; }  // kaç yanlış doğruyu götürüyor ayarlardan ayarlansın
    }
}
