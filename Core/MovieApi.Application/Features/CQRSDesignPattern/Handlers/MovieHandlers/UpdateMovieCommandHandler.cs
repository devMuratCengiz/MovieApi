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
            var value = await _context.Movies.FindAsync(command.Id);

            value.Description = command.Description;
            value.ReleaseDate = command.ReleaseDate;
            value.Rating = command.Rating;
            value.CreatedYear = command.CreatedYear;
            value.Duration = command.Duration;
            value.Status = command.Status;
            value.CoverImageUrl = command.CoverImageUrl;
            value.Title = command.Title;

            await _context.SaveChangesAsync();
        }
    }
}
