using Microsoft.EntityFrameworkCore;
using MoviApi.Application.Features.CQRS.Results.CategoryResults;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler(MovieContext _context)
    {
        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var values = await _context.Categories.ToListAsync();
            return values.Select(x => new GetCategoryQueryResult
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }

    }
}
