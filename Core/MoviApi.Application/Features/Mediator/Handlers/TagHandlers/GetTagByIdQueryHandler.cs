using MediatR;
using MoviApi.Application.Features.Mediator.Queries.TagQueries;
using MoviApi.Application.Features.Mediator.Results.TagResults;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.Mediator.Handlers.TagHandlers
{
    public class GetTagByIdQueryHandler(MovieContext _context) : IRequestHandler<GetTagByIdQuery, GetTagByIdQueryResult>
    {
        public async Task<GetTagByIdQueryResult> Handle(GetTagByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Tags.FindAsync(request.Id);
            return new GetTagByIdQueryResult
            {
                Id = value.Id,
                Title = value.Title
            };
        }
    }
}
