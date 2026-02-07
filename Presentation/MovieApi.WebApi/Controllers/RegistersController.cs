using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviApi.Application.Features.CQRS.Commands.UserRegisterCommands;
using MoviApi.Application.Features.CQRS.Handlers.UserRegisterHandlers;

namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistersController(CreateUserRegisterCommandHandler _handler) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateUserRegister(CreateUserRegisterCommand command)
        {
            await _handler.Handle(command);
            return Ok();
        }
    }
}
