using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviApi.Application.Features.Mediator.Commands.CastCommands;
using MoviApi.Application.Features.Mediator.Queries.CastQueries;

namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastsController(IMediator _mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> CastList()
        {
            var values = await _mediator.Send(new GetCastQuery());
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCast(CreateCastCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCast(int id)
        {
            await _mediator.Send(new RemoveCastCommand(id));
            return Ok();
        }
        [HttpGet("GetCast")]
        public async Task<IActionResult> GetCast (int id)
        {
            var value = await _mediator.Send(new GetCastByIdQuery(id));
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCast(UpdateCastCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
    }
}
