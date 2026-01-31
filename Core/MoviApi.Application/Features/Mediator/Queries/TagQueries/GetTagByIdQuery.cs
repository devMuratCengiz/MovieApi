using MediatR;
using MoviApi.Application.Features.Mediator.Results.TagResults;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.Mediator.Queries.TagQueries
{
    public class GetTagByIdQuery : IRequest<GetTagByIdQueryResult>
    {
        public GetTagByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
