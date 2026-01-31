using MediatR;
using MoviApi.Application.Features.Mediator.Commands.CastCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.Mediator.Handlers.TagHandlers
{
    public class CreateTagCommandHandler(MovieContext _context) : IRequestHandler<CreateCastCommand>
    {
        public async Task Handle(CreateCastCommand request, CancellationToken cancellationToken)
        {
            _context.Tags.Add(new Tag
            {
                Title = request.Title,
            });
            await _context.SaveChangesAsync();
        }
    }
}
