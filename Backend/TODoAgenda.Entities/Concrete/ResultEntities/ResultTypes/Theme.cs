using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODoAgenda.Entities.Concrete.ResultEntities.ResultTypes
{
    public class Theme
    {
        public int themeId { get; set; }
        public string themeDescription { get; set; }
    }
}
