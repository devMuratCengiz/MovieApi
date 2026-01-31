using MoviApi.Application.Features.CQRS.Commands.CategoryCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler(MovieContext _context)
    {
        public async Task Handle(CreateCategoryCommand command)
        {
            _context.Categories.Add(new()
            {
                Name = command.Name
            });
            await _context.SaveChangesAsync();
        }
    }
}
