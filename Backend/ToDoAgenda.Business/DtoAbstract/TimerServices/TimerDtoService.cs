using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.DTOLayer.ToDoAgendaDtos.TimerDtos;

namespace ToDoAgenda.Business.DtoAbstract.TimerServices
{
    public interface TimerDtoService
    {
        Task<List<TimerDto>> GetAll();
        Task<TimerDto> GetById();
        Task<TimerDto> Add(TimerWithoutIdDto timerWithoutIdDto);
        Task<TimerDto> Update(TimerDto timerDto);
        Task Delete(TimerDto timerDto);
    }
}
