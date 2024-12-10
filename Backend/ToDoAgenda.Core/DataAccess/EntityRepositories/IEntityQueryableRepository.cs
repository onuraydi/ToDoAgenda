using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Entities;

namespace ToDoAgenda.Core.DataAccess.EntityRepositories
{
    // Queryable yani sorgulanabilir operasyonların business tarafında çalışabilmesi için yani context kapanmadan çalışabilmesi için bu interface'i yazıyoruz


    // burada where ile koşullar koyduk
    public interface IEntityQueryableRepository<T> where T : class, IEntity, new()
    {
        // select operasyonları için tek bir implementasyon yapılır
        IQueryable<T> Table { get; } // bu imza genellikle Table ismi ile adlandırılır
    }
}
