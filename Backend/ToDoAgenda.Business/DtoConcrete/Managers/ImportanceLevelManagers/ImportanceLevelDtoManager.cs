using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Business.DtoAbstract.ImportanceLevelServices;
using ToDoAgenda.DataAccess.Abstract.ForDto;
using ToDoAgenda.DTOLayer.ToDoAgendaDtos.ImportanceLevelDtos;

namespace ToDoAgenda.Business.DtoConcrete.Managers.ImportanceLevelManagers
{
    public class ImportanceLevelDtoManager : IImportanceLevelDtoService
    {
        private readonly IImportanceLevelDtoDal _importanceLevelDtoDal;
        private readonly IMapper _mapper;

        public ImportanceLevelDtoManager(IImportanceLevelDtoDal importanceLevelDtoDal, IMapper mapper)
        {
            _importanceLevelDtoDal = importanceLevelDtoDal;
            _mapper = mapper;
        }

        public async Task<ImportanceLevelDto> Add(ImportanceLevelDto importanceLevelDto)
        {
            return await _importanceLevelDtoDal.Add(importanceLevelDto);
        }

        public async Task Delete(ImportanceLevelDto importanceLevelDto)
        {
            await _importanceLevelDtoDal.Delete(importanceLevelDto);
        }

        public async Task<List<ImportanceLevelDto>> GetAll()
        {
            var values = await _importanceLevelDtoDal.GetAll();
            return _mapper.Map<List<ImportanceLevelDto>>(values);
        }

        public async Task<ImportanceLevelDto> GetById(int id)
        {
            return await _importanceLevelDtoDal.Get(x => x.importanceLevelId == id);
        }

        public async Task<ImportanceLevelDto> Update(ImportanceLevelDto importanceLevelDto)
        {
            return await _importanceLevelDtoDal.Update(importanceLevelDto);
        }
    }
}
