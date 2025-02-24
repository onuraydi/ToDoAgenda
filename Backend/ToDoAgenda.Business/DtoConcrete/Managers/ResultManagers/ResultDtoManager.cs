using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Business.DtoAbstract.ResultServices;
using ToDoAgenda.DataAccess.Abstract.ForDto;
using ToDoAgenda.DTOLayer.ToDoAgendaDtos.ResultDtos;

namespace ToDoAgenda.Business.DtoConcrete.Managers.ResultManagers
{
    public class ResultDtoManager : IResultDtoService
    {
        private readonly IResultDtoDal _resultDtoDal;
        private readonly IMapper _mapper;

        public ResultDtoManager(IResultDtoDal resultDtoDal, IMapper mapper)
        {
            _resultDtoDal = resultDtoDal;
            _mapper = mapper;
        }

        public async Task<ResultDto> Add(ResultDto resultDto)
        {
            return await _resultDtoDal.Add(resultDto);
        }

        public async Task Delete(ResultDto resultDto)
        {
            await _resultDtoDal.Delete(resultDto);
        }

        public async Task<List<ResultDto>> GetAll()
        {
            var values = await _resultDtoDal.GetAll();
            return _mapper.Map<List<ResultDto>>(values);
        }

        public async Task<ResultDto> GetById(int id)
        {
            return await _resultDtoDal.Get(x => x.resultTypeId == id);
        }

        public async Task<ResultDto> Update(ResultDto resultDto)
        {
            return await _resultDtoDal.Update(resultDto);
        }
    }
}
