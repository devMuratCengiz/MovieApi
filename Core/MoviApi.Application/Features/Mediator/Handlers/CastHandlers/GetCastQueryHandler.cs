using MediatR;
using Microsoft.EntityFrameworkCore;
using MoviApi.Application.Features.Mediator.Queries.CastQueries;
using MoviApi.Application.Features.Mediator.Results.CastResults;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.Mediator.Handlers.CastHandlers
{
    public class GetCastQueryHandler(MovieContext _context) : IRequestHandler<GetCastQuery, List<GetCastQueryResult>>
    {
        public async Task<List<GetCastQueryResult>> Handle(GetCastQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Casts.ToListAsync();
            return values.Select(x => new GetCastQueryResult
            {
                Biography = x.Biography,
                Id = x.Id,
                ImageUrl = x.ImageUrl,
                Name = x.Name,
                Overview = x.Overview,
                Surname = x.Surname,
                Title = x.Title
            }).ToList();
        }
    }
}
