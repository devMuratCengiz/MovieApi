using MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieApi.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class UpdateMovieCommandHandler
    {
        private readonly MovieContext _context;

        public UpdateMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateMovieCommand command)
        {
            var movie = await _context.Movies.FindAsync(command.Id);
            movie.Rating = command.Rating;
            movie.Title = command.Title;
            movie.Description = command.Description;
            movie.Status = command.Status;
            movie.Duration = command.Duration;
            movie.ReleaseDate = command.ReleaseDate;
            movie.CreatedYear = command.CreatedYear;
            movie.CoverImageUrl = command.CoverImageUrl;
            await _context.SaveChangesAsync();
        }
    }
}
