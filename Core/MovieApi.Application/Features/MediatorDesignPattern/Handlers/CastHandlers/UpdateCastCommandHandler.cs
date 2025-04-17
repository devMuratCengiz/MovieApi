using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.CastCommands;
using MovieApi.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.CastHandlers
{
    public class UpdateCastCommandHandler : IRequestHandler<UpdateCastCommand>
    {
        private readonly MovieContext _context;

        public UpdateCastCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateCastCommand request, CancellationToken cancellationToken)
        {
            var cast = await _context.Casts.FindAsync(request.Id);
            cast.Name = request.Name;
            cast.Surname = request.Surname;
            cast.Overview = request.Overview;
            cast.ImageUrl = request.ImageUrl;
            cast.Biography = request.Biography;
            cast.Title = request.Title;
            await _context.SaveChangesAsync();
        }
    }
}
