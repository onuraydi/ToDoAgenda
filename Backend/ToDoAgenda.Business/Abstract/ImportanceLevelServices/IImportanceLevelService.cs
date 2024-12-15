using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TODoAgenda.Entities.Concrete;
using Task =  System.Threading.Tasks.Task;

namespace ToDoAgenda.Business.Abstract.ImportanceLevelServices
{
    public interface IImportanceLevelService
    {
        Task<List<ImportanceLevel>> GetAll();
        Task<ImportanceLevel> GetById(int id);
        /* Task<ImportanceLevel> GetByImportanceLevelDegree(int degree);*/  // diğer işlemler sonra ayarlanacak
        Task<ImportanceLevel> Add(ImportanceLevel importanceLevel);
        Task<ImportanceLevel> Update(ImportanceLevel importanceLevel);
        Task Delete(ImportanceLevel importanceLevel);
    }
}
