using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoAgenda.Business.Abstract.UserServices;
using TODoAgenda.Entities.Concrete;

namespace ToDoAgenda.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _userService.GetAll();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var values = await _userService.GetById(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> Add(User user)
        {
            var values = await _userService.Add(user);
            return Ok(values);
        }

        [HttpPut]
        public async Task<IActionResult> Update(User user)
        {
            var values = await _userService.Update(user);
            return Ok(values);
        }
    }
}
