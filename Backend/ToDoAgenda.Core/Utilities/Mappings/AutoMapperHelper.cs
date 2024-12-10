using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAgenda.Core.Utilities.Mappings
{
    public class AutoMapperHelper
    {
        // statik mapper kullanımı performans atrışı sağlıyor (gpt'ye göre) arşivlendi bir bak
        public static List<T> MapToSameTypeList<T>(List<T> list)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<T, T>();
            });

            IMapper mapper = config.CreateMapper();

            List<T> result = mapper.Map<List<T>, List<T>>(list);
            return result;
        }

        public static T MapToSameType<T>(T obj) 
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<T, T>();
            });

            IMapper mapper = config.CreateMapper();
            T result = mapper.Map<T,T>(obj);
            return result;
        }
    }
}
