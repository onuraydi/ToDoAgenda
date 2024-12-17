using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoAgenda.Business.Abstract.TimerServices;
using Timer = TODoAgenda.Entities.Concrete.Timer;

namespace ToDoAgenda.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimersController : ControllerBase
    {
        private readonly ITimerService _timerService;

        public TimersController(ITimerService timerService)
        {
            _timerService = timerService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _timerService.GetAll();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var values = await _timerService.GetById(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Timer timer)
        {
            var values= await _timerService.Add(timer);
            return Ok(values);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Timer timer)
        {
            var values = await _timerService.Update(timer);
            return Ok(values);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Timer timer)
        {
            await _timerService.Delete(timer);
            return Ok("Silme işlemi başarılı");
        }
    }
}
