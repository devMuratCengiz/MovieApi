using MoviApi.Application.Features.CQRS.Commands.CategoryCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler(MovieContext _context)
    {
        public async void Handle(RemoveCategoryCommand command)
        {
            var value = await _context.Categories.FindAsync(command.Id);
            _context.Categories.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
