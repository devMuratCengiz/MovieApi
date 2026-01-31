using MediatR;
using MoviApi.Application.Features.Mediator.Queries.CastQueries;
using MoviApi.Application.Features.Mediator.Results.CastResults;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.Mediator.Handlers.CastHandlers
{
    public class GetCastByIdQueryHandler(MovieContext _context) : IRequestHandler<GetCastByIdQuery, GetCastByIdQueryResult>
    {
        public async Task<GetCastByIdQueryResult> Handle(GetCastByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Casts.FindAsync(request.Id);
            return new GetCastByIdQueryResult
            {
                Biography = value.Biography,
                Id = value.Id,
                ImageUrl = value.ImageUrl,
                Name = value.Name,
                Overview = value.Overview,
                Surname = value.Surname,
                Title = value.Title
            };
        }
    }
}
