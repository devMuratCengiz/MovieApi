using MediatR;
using MoviApi.Application.Features.Mediator.Commands.TagCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.Mediator.Handlers.TagHandlers
{
    public class RemoveTagCommandHandler(MovieContext _context) : IRequestHandler<RemoveTagCommand>
    {
        public async Task Handle(RemoveTagCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Tags.FindAsync(request.Id);
            _context.Tags.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
