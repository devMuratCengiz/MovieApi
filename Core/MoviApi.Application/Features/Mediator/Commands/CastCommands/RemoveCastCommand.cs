using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.Mediator.Commands.CastCommands
{
    public class RemoveCastCommand : IRequest
    {
        public RemoveCastCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
