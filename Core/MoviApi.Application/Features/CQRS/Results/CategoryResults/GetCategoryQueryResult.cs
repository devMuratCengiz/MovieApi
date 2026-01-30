using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.CQRS.Results.CategoryResults
{
    public class GetCategoryQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
