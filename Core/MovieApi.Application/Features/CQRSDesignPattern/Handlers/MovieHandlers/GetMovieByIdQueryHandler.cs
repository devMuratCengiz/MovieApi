using MovieApi.Application.Features.CQRSDesignPattern.Queries.MovieQueries;
using MovieApi.Application.Features.CQRSDesignPattern.Results.MovieResults;
using MovieApi.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class GetMovieByIdQueryHandler
    {
        private readonly MovieContext _context;

        public GetMovieByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<GetMovieByIdQueryResult> Handle(GetMovieByIdQuery query)
        {
            var movie = await _context.Movies.FindAsync(query.Id);
            return new GetMovieByIdQueryResult
            {
                CoverImageUrl = movie.CoverImageUrl,
                CreatedYear = movie.CreatedYear,
                Description = movie.Description,
                Duration = movie.Duration,
                Id = movie.Id,
                Rating = movie.Rating,
                ReleaseDate = movie.ReleaseDate,
                Status = movie.Status,
                Title = movie.Title
            };
        }
    }
}
