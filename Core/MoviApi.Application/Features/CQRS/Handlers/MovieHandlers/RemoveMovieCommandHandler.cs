using MoviApi.Application.Features.CQRS.Commands.MovieCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.CQRS.Handlers.MovieHandlers
{
    public class RemoveMovieCommandHandler(MovieContext _context)
    {
        public async void Handle(RemoveMovieCommand command)
        {
            var value = await _context.Movies.FindAsync(command.Id);
            _context.Movies.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
