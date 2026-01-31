using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.CQRS.Commands.MovieCommands
{
    public class RemoveMovieCommand
    {
        public RemoveMovieCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
