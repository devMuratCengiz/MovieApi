using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.Mediator.Commands.TagCommands
{
    public class RemoveTagCommand : IRequest
    {
        public RemoveTagCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
