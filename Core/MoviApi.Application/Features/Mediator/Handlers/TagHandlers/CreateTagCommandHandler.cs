using MediatR;
using MoviApi.Application.Features.Mediator.Commands.CastCommands;
using MoviApi.Application.Features.Mediator.Commands.TagCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.Mediator.Handlers.TagHandlers
{
    public class CreateTagCommandHandler(MovieContext _context) : IRequestHandler<CreateTagCommand>
    {
        public async Task Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
            await _context.Tags.AddAsync(new Tag
            {
                Title = request.Title,
            });
            await _context.SaveChangesAsync();
        }
    }
}
