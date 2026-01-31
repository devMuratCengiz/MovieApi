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
        public IActionResult CastList()
        {
            var values = _mediator.Send(new GetCastQuery());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateCast(CreateCastCommand command)
        {
            _mediator.Send(command);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteCast(int id)
        {
            _mediator.Send(new RemoveCastCommand(id));
            return Ok();
        }
        [HttpGet("GetCast")]
        public IActionResult GetCast (int id)
        {
            var value = _mediator.Send(new GetCastByIdQuery(id));
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateCast(UpdateCastCommand command)
        {
            _mediator.Send(command);
            return Ok();
        }
    }
}
