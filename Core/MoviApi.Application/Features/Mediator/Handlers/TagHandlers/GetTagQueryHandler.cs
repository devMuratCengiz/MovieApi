using MediatR;
using Microsoft.EntityFrameworkCore;
using MoviApi.Application.Features.Mediator.Queries.TagQueries;
using MoviApi.Application.Features.Mediator.Results.TagResults;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.Mediator.Handlers.TagHandlers
{
    public class GetTagQueryHandler(MovieContext _context) : IRequestHandler<GetTagQuery, List<GetTagQueryResult>>
    {
        public async Task<List<GetTagQueryResult>> Handle(GetTagQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Tags.ToListAsync();
            return value.Select(x => new GetTagQueryResult
            {
                Id = x.Id,
                Title = x.Title
            }).ToList();
        }
    }
}
