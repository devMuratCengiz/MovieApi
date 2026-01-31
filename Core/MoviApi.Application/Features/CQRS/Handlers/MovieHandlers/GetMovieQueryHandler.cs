using Microsoft.EntityFrameworkCore;
using MoviApi.Application.Features.CQRS.Results.MovieResults;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.CQRS.Handlers.MovieHandlers
{
    public class GetMovieQueryHandler(MovieContext _context)
    {
        public async Task<List<GetMovieQueryResult>> Handle()
        {
            var values = await _context.Movies.ToListAsync();
            return values.Select(x=> new GetMovieQueryResult
            {
                Id = x.Id,
                Title = x.Title,
                CoverImageUrl = x.CoverImageUrl,
                Rating = x.Rating,
                Description = x.Description,
                Duration = x.Duration,
                ReleaseDate = x.ReleaseDate,
                CreatedYear = x.CreatedYear,
                Status = x.Status
            }).ToList();
        }
    }
}
