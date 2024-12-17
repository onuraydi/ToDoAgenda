using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Npgsql.EntityFrameworkCore.PostgreSQL.Query.Expressions.Internal;
using System.Runtime.InteropServices;
using ToDoAgenda.Business.Abstract.DefinedTaskServices;
using TODoAgenda.Entities.Concrete;

namespace ToDoAgenda.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefinedTasksController : ControllerBase
    {
        private readonly IDefinedTaskService _definedTaskService;

        public DefinedTasksController(IDefinedTaskService definedTaskService)
        {
            _definedTaskService = definedTaskService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _definedTaskService.GetAll();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var values = await _definedTaskService.GetById(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> Add(DefinedTask definedTask)
        {
            var values = await _definedTaskService.Add(definedTask);
            return Ok(values);
        }

        [HttpPut]
        public async Task<IActionResult> Update(DefinedTask definedTask)
        {
            var values = await _definedTaskService.Update(definedTask);
            return Ok(values);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(DefinedTask definedTask)
        {
            await _definedTaskService.Delete(definedTask);
            return Ok("Silme işlemi başarılı");
        }
    }
}
