using MoviApi.Application.Features.CQRS.Queries.MovieQueries;
using MoviApi.Application.Features.CQRS.Results.MovieResults;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.CQRS.Handlers.MovieHandlers
{
    public class GetMovieByIdQueryHandler(MovieContext _context)
    {
        public async Task<GetMovieByIdQueryResult> Handle(GetMovieByIdQuery query)
        {
            var value = await _context.Movies.FindAsync(query.Id);
            return new GetMovieByIdQueryResult
            {
                Id = value.Id,
                Title = value.Title,
                CoverImageUrl = value.CoverImageUrl,
                Rating = value.Rating,
                Description = value.Description,
                Duration = value.Duration,
                ReleaseDate = value.ReleaseDate,
                CreatedYear = value.CreatedYear,
                Status = value.Status
            };
        }
    }
}
