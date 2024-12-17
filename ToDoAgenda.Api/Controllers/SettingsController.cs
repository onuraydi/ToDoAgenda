using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoAgenda.Business.Abstract.SettingServices;
using TODoAgenda.Entities.Concrete;

namespace ToDoAgenda.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingsController : ControllerBase
    {
        private readonly ISettingService _settingService;

        public SettingsController(ISettingService settingService)
        {
            _settingService = settingService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _settingService.GetAll();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var values = await _settingService.GetById(id);
            return Ok(values);
        }


        [HttpPost]
        public async Task<IActionResult> Add(Setting setting)
        {
            var values = await _settingService.Add(setting);
            return Ok(values);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Setting setting)
        {
            var values = await _settingService.Update(setting);
            return Ok(values);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Setting setting)
        {
            await _settingService.Delete(setting);
            return Ok();
        }
    }
}
