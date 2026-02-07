using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviApi.Application.Features.Mediator.Commands.TagCommands;
using MoviApi.Application.Features.Mediator.Queries.TagQueries;

namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController(IMediator _mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> TagList()
        {
            var values =await _mediator.Send(new GetTagQuery());
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTag(CreateTagCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
        [HttpGet("GetTag")]
        public async Task<IActionResult> GetTag(int id)
        {
            var value = await _mediator.Send(new GetTagByIdQuery(id));
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTag(UpdateTagCommand command)
        {
             await _mediator.Send(command);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteTag(int id)
        {
            await _mediator.Send(new RemoveTagCommand(id));
            return Ok();
        }
    }
}
