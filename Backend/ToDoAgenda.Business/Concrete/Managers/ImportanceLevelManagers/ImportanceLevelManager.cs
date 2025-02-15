using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoAgenda.Business.Abstract.ImportanceLevelServices;
using ToDoAgenda.DataAccess.Abstract.ForEntity;
using TODoAgenda.Entities.Concrete;
using Task = System.Threading.Tasks.Task;

namespace ToDoAgenda.Business.Concrete.Managers.ImportanceLevelManagers
{
    public class ImportanceLevelManager : IImportanceLevelService
    {
        private IImportanceLevelDal _importanceLevelDal;
        private IMapper _mapper;

        public ImportanceLevelManager(IImportanceLevelDal importanceLevelDal, IMapper mapper)
        {
            _importanceLevelDal = importanceLevelDal;
            _mapper = mapper;
        }

        public async Task<ImportanceLevel> Add(ImportanceLevel importanceLevel)
        {
            return await _importanceLevelDal.Add(importanceLevel);
        }

        public async Task Delete(ImportanceLevel importanceLevel)
        {
            await _importanceLevelDal.Delete(importanceLevel);
        }

        public async Task<List<ImportanceLevel>> GetAll()
        {
            var values = await _importanceLevelDal.GetAll();
            return _mapper.Map<List<ImportanceLevel>>(values);  
        }

        public async Task<ImportanceLevel> GetById(int id)
        {
            return await _importanceLevelDal.Get(x => x.importanceLevelId == id);
        }

        public async Task<ImportanceLevel> Update(ImportanceLevel importanceLevel)
        {
            return await _importanceLevelDal.Update(importanceLevel);
        }
    }
}
