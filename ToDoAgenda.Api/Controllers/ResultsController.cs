using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoAgenda.Business.Abstract.ResutlServices;
using TODoAgenda.Entities.Concrete;

namespace ToDoAgenda.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultsController : ControllerBase
    {
        private readonly IResultService _resultService;
        private readonly IValidator<Result> _validator;
        public ResultsController(IResultService resultService, IValidator<Result> validator)
        {
            _resultService = resultService;
            _validator = validator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _resultService.GetAll();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var values = await _resultService.GetById(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Result result)
        {
            var validationResult = await _validator.ValidateAsync(result);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult);
            }
            var values = await _resultService.Add(result);
            return Ok(values);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Result result)
        {
            var validationResult = await _validator.ValidateAsync(result);

            if(!validationResult.IsValid)
            {
                return BadRequest(validationResult);
            }
            var values = await _resultService.Update(result);
            return Ok(values);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Result result)
        {
            await _resultService.Delete(result);
            return Ok("Silme işlemi başarılı");
        }
    }
}
