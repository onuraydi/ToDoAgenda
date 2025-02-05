using FluentValidation;
using FluentValidation.AspNetCore;
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
        private readonly IValidator<DefinedTask> _validator;

        public DefinedTasksController(IDefinedTaskService definedTaskService, IValidator<DefinedTask> validator)
        {
            _definedTaskService = definedTaskService;
            _validator = validator;
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
            var validationResult = await _validator.ValidateAsync(definedTask);

            if (!validationResult.IsValid)
            {
                //validationResult.AddToModelState(this.ModelState);
                return BadRequest(validationResult);
                //return ValidationProblem(validationResult.ToString());
            }
            var values = await _definedTaskService.Add(definedTask);
            return Ok(values);

        }

        [HttpPut]
        public async Task<IActionResult> Update(DefinedTask definedTask)
        {
            var validationResult = await _validator.ValidateAsync(definedTask);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult);
            }
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
