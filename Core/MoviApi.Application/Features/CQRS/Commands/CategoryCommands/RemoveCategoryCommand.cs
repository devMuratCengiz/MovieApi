using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.CQRS.Commands.CategoryCommands
{
    public class RemoveCategoryCommand
    {
        public int Id { get; set; }
    }
}
