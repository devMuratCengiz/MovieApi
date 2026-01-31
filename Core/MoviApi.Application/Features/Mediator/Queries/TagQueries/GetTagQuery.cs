using MediatR;
using MoviApi.Application.Features.Mediator.Results.TagResults;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.Mediator.Queries.TagQueries
{
    public class GetTagQuery:IRequest<List<GetTagQueryResult>>
    {
    }
}
