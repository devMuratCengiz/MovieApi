using MediatR;
using MoviApi.Application.Features.Mediator.Commands.CastCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.Mediator.Handlers.CastHandlers
{
    public class UpdateCastCommandHandler(MovieContext _context) : IRequestHandler<UpdateCastCommand>
    {
        public async Task Handle(UpdateCastCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Casts.FindAsync(request.Id);
            value.Surname = request.Surname;
            value.Overview = request.Overview;
            value.Name = request.Name;
            value.ImageUrl = request.ImageUrl;
            value.Biography = request.Biography;
            value.Title = request.Title;

            await _context.SaveChangesAsync();
        }
        
    }
}
