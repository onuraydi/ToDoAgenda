using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODoAgenda.Entities.Concrete.ResultEntities.ResultTypes
{
    public class Net
    {
        public int netId { get; set; }
        public int totalQuestionCount {  get; set; }
        public int trueCount { get; set; }
        public int falseCount { get; set; }
        public float totalNet
        {
            get
            {
                return trueCount - (falseCount / 4);   // buradaki 4 ileride ayarlardan alınan bir sabit ile değiştirilecek
            }
            set
            {

            }
        }
    }
}
