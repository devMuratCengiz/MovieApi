using MediatR;
using MoviApi.Application.Features.Mediator.Results.CastResults;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.Mediator.Queries.CastQueries
{
    public class GetCastQuery : IRequest<List<GetCastQueryResult>>
    {
    }
}
