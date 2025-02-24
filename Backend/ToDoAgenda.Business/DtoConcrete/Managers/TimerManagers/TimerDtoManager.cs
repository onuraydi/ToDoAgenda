using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Business.DtoAbstract.TaskServices;
using ToDoAgenda.Business.DtoAbstract.TimerServices;
using ToDoAgenda.DataAccess.Abstract.ForDto;
using ToDoAgenda.DTOLayer.ToDoAgendaDtos.TimerDtos;

namespace ToDoAgenda.Business.DtoConcrete.Managers.TimerManagers
{
    public class TimerDtoManager : ITimerDtoService
    {
        private readonly ITimerDtoDal _timerDtoDal;
        private readonly IMapper _mapper;

        public TimerDtoManager(ITimerDtoDal timerDtoDal, IMapper mapper)
        {
            _timerDtoDal = timerDtoDal;
            _mapper = mapper;
        }

        public async Task<TimerDto> Add(TimerDto timerDto)
        {
            return await _timerDtoDal.Add(timerDto);
        }

        public async Task Delete(TimerDto timerDto)
        {
            await _timerDtoDal.Delete(timerDto);
        }

        public async Task<List<TimerDto>> GetAll()
        {
            var values = await _timerDtoDal.GetAll();
            return _mapper.Map<List<TimerDto>>(values);
        }

        public async Task<TimerDto> GetById(int id)
        {
            return await _timerDtoDal.Get(x => x.timerId == id);
        }

        public async Task<TimerDto> Update(TimerDto timerDto)
        {
            return await _timerDtoDal.Update(timerDto);
        }
    }
}
