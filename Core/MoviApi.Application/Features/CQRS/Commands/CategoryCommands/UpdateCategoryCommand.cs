using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.CQRS.Commands.CategoryCommands
{
    public class UpdateCategoryCommand
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
