using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoAgenda.Business.Abstract.TaskServices;
using Task = TODoAgenda.Entities.Concrete.Task;


namespace ToDoAgenda.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _taskService.GetAll();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var values = await _taskService.GetById(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Task task)
        {
            var values = await _taskService.Add(task);
            return Ok(values);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Task task)
        {
            var values = await _taskService.Update(task);
            return Ok(values);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Task task)
        {
            await _taskService.Delete(task);
            return Ok("Silme işlemi başarılı");
        }
    }
}
