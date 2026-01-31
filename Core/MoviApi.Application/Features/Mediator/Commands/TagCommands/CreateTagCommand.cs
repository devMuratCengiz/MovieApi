using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.Mediator.Commands.TagCommands
{
    public class CreateTagCommand : IRequest
    {
        public string Title { get; set; }
    }
}
