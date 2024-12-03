using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Entities;

namespace TODoAgenda.Entities.Concrete
{
    public class Setting:IEntity
    {
        public int SettingId { get; set; }
        // ayarlar tek tek entity olarak eklense ve burada tümayarlar tutulsa nasıl olur
    }
}
