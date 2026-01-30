using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.CQRS.Commands.CategoryCommands
{
    public class CreateCategoryCommand
    {
        public string Name { get; set; }
    }
}
