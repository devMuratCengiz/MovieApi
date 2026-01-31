using MoviApi.Application.Features.CQRS.Queries.CategoryQueries;
using MoviApi.Application.Features.CQRS.Results.CategoryResults;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler(MovieContext _context)
    {
        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
        {
            var value = await _context.Categories.FindAsync(query.Id);
            if (value == null)
                return null;
            return new GetCategoryByIdQueryResult
            {
                Id = value.Id,
                Name = value.Name
            };

        }
    }
}
