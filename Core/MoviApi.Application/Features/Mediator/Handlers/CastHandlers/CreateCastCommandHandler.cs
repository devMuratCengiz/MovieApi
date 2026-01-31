using MediatR;
using MoviApi.Application.Features.Mediator.Commands.CastCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.Mediator.Handlers.CastHandlers
{
    public class CreateCastCommandHandler(MovieContext _context) : IRequestHandler<CreateCastCommand>
    {
        public async Task Handle(CreateCastCommand request, CancellationToken cancellationToken)
        {
            _context.Casts.Add(new Cast
            {
                Biography = request.Biography,
                ImageUrl = request.ImageUrl,
                Name = request.Name,
                Overview = request.Overview,
                Surname = request.Surname,
                Title = request.Title
            });
            await _context.SaveChangesAsync();
        }
    }
}
