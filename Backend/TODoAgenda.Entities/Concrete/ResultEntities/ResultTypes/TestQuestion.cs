using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODoAgenda.Entities.Concrete.ResultEntities.ResultTypes
{
    public class TestQuestion
    {
        public int testQuestionId { get; set; }
        public int totalQuestionCount { get; set; }
        public int trueCount { get; set; }
        public int falseCount { get; set; }
    }
}
