using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Entities;

namespace TODoAgenda.Entities.Concrete
{
    public class User:IEntity
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserEmail { get; set; }
        /*public string UserPassword { get; set; }*/   // Bu iki kısım belki identity katmanında farklı şekilde tutulabilir.
        // user role kısmı identityde tutalacak şifre ve diğerleri de bu büyük ihtimalle kalkacak
    }
}
