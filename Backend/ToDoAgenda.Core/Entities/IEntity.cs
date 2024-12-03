using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAgenda.Core.Entities
{
    public interface IEntity
    {
        // Bizim bunu tanımlama amacımız generic yapılarla çalıştığımızda Entityler için bir imza olarak kullanmak
        // mesela bir yapıyı entitylerden oluşturacağımız zaman onun Ientityden implemente edilmiş olması şartı vb sağlayabiliriz
    }
}
