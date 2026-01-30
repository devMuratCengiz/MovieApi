using MoviApi.Application.Features.CQRS.Commands.CategoryCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler(MovieContext _context)
    {
        public async void Handle(UpdateCategoryCommand command)
        {
            var value = await _context.Categories.FindAsync(command.Id);
            value.Name = command.Name;
            await _context.SaveChangesAsync();
        }
    }
}
