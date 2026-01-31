using MediatR;
using MoviApi.Application.Features.Mediator.Commands.TagCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.Mediator.Handlers.TagHandlers
{
    public class UpdateTagCommandHandler(MovieContext _context) : IRequestHandler<UpdateTagCommand>
    {
        public async Task Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Tags.FindAsync(request.Id);
            value.Title = request.Title;
            await _context.SaveChangesAsync();
        }
    }
}
