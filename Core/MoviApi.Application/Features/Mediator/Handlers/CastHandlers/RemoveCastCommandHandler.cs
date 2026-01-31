using MediatR;
using MoviApi.Application.Features.Mediator.Commands.CastCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.Mediator.Handlers.CastHandlers
{
    public class RemoveCastCommandHandler(MovieContext _context) : IRequestHandler<RemoveCastCommand>
    {
        public async Task Handle(RemoveCastCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Casts.FindAsync(request.Id);
            _context.Casts.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
