﻿using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Queries.CastQueries;
using MovieApi.Application.Features.MediatorDesignPattern.Results.CastResults;
using MovieApi.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.CastHandlers
{
    public class GetCastByIdQueryHandler : IRequestHandler<GetCastByIdQuery, GetCastByIdQueryResult>
    {
        private readonly MovieContext _context;

        public GetCastByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<GetCastByIdQueryResult> Handle(GetCastByIdQuery request, CancellationToken cancellationToken)
        {
            var cast = await _context.Casts.FindAsync(request.Id);
            return new GetCastByIdQueryResult
            {
                Id = cast.Id,
                Biography = cast.Biography,
                ImageUrl = cast.ImageUrl,
                Name = cast.Name,
                Overview = cast.Overview,
                Surname = cast.Surname,
                Title = cast.Title
            };
        }
    }
}
