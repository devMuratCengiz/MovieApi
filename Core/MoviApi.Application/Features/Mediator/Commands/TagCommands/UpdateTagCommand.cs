using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.Mediator.Commands.TagCommands
{
    public class UpdateTagCommand : IRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
