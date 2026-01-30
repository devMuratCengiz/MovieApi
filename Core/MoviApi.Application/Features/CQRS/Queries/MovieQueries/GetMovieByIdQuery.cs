using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.CQRS.Queries.MovieQueries
{
    public class GetMovieByIdQuery
    {
        public int Id { get; set; }
    }
}
