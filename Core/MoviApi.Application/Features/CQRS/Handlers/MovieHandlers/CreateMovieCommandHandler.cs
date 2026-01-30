using MoviApi.Application.Features.CQRS.Commands.MovieCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.CQRS.Handlers.MovieHandlers
{
    public class CreateMovieCommandHandler(MovieContext _context)
    {
        public async void Handle(CreateMovieCommand command)
        {
            _context.Movies.Add(new()
            {
                Title = command.Title,
                CoverImageUrl = command.CoverImageUrl,
                Rating = command.Rating,
                Description = command.Description,
                Duration = command.Duration,
                ReleaseDate = command.ReleaseDate,
                CreatedYear = command.CreatedYear,
                Status = command.Status
            }); 
            await _context.SaveChangesAsync();
        }
    }
}
