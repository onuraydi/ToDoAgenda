using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoAgenda.Business.Abstract.ImportanceLevelServices;
using TODoAgenda.Entities.Concrete;

namespace ToDoAgenda.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImportanceLevelsController : ControllerBase
    {
        private readonly IImportanceLevelService _importanceLevelService;
        private readonly IValidator<ImportanceLevel> _validator;

        public ImportanceLevelsController(IImportanceLevelService importanceLevelService, IValidator<ImportanceLevel> validator)
        {
            _importanceLevelService = importanceLevelService;
            _validator = validator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _importanceLevelService.GetAll();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var values = await _importanceLevelService.GetById(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ImportanceLevel importanceLevel)
        {
            var validationResult = await _validator.ValidateAsync(importanceLevel);
            
            if(!validationResult.IsValid)
            {
                return BadRequest(validationResult);
            }
            var values = await _importanceLevelService.Add(importanceLevel);
            return Ok(values);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ImportanceLevel importanceLevel)
        {
            var validationResult = await _validator.ValidateAsync(importanceLevel);

            if(!validationResult.IsValid)
            {
                return BadRequest(validationResult);
            }
            var values = await _importanceLevelService.Update(importanceLevel);
            return Ok(values);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(ImportanceLevel importanceLevel)
        {
            await _importanceLevelService.Delete(importanceLevel);
            return Ok("Silme işlemi başarılı");
        }
    }
}
