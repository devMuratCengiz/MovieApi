using MoviApi.Application.Features.CQRS.Commands.MovieCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.CQRS.Handlers.MovieHandlers
{
    public class UpdateMovieCommandHandler(MovieContext _context)
    {
        public async void Handle(UpdateMovieCommand command)
        {
            var value = await _context.Movies.FindAsync(command.Id);
            value.Rating = command.Rating;
            value.Title = command.Title;
            value.Status = command.Status;
            value.Duration = command.Duration;
            value.CoverImageUrl = command.CoverImageUrl;
            value.Description = command.Description;
            value.ReleaseDate = command.ReleaseDate;
            value.CreatedYear = command.CreatedYear;
            
            await _context.SaveChangesAsync();
        }
    }
}
