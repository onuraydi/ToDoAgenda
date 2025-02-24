using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Business.DtoAbstract.DefinedTaskServices;
using ToDoAgenda.DataAccess.Abstract.ForDto;
using ToDoAgenda.DTOLayer.ToDoAgendaDtos.DefinedTaskDtos;

namespace ToDoAgenda.Business.DtoConcrete.Managers.DefinedTaskManagers
{
    class DefinedTaskDtoManager : IDefinedTaskDtoService
    {
        private readonly IDefinedTaskDtoDal _definedTaskDtoDal;
        private readonly IMapper _mapper;

        public DefinedTaskDtoManager(IDefinedTaskDtoDal definedTaskDtoDal, IMapper mapper)
        {
            _definedTaskDtoDal = definedTaskDtoDal;
            _mapper = mapper;
        }


        public async Task<DefinedTaskDto> Add(DefinedTaskDto definedTaskDto)
        {
            return await _definedTaskDtoDal.Add(definedTaskDto);
        }

        public async Task Delete(DefinedTaskDto definedTaskDto)
        {
            await _definedTaskDtoDal.Delete(definedTaskDto);
        }

        public async Task<List<DefinedTaskDto>> GetAll()
        {
            var values = await _definedTaskDtoDal.GetAll();
            return _mapper.Map<List<DefinedTaskDto>>(values);
        }

        public async Task<DefinedTaskDto> GetById(int id)
        {
            return await _definedTaskDtoDal.Get(X => X.DefinedTaskId == id);
        }

        public async Task<DefinedTaskDto> Update(DefinedTaskDto definedTaskDto)
        {
            return await _definedTaskDtoDal.Update(definedTaskDto);
        }
    }
}
