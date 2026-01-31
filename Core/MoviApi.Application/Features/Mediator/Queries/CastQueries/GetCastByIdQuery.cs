using MediatR;
using MoviApi.Application.Features.Mediator.Results.CastResults;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.Mediator.Queries.CastQueries
{
    public class GetCastByIdQuery : IRequest<GetCastByIdQueryResult>
    {
        public GetCastByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
