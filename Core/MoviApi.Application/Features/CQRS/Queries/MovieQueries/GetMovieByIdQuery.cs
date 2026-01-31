using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.CQRS.Queries.MovieQueries
{
    public class GetMovieByIdQuery
    {
        public GetMovieByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
