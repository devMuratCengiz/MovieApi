using System;
using System.Collections.Generic;
using System.Text;

namespace MoviApi.Application.Features.CQRS.Commands.UserRegisterCommands
{
    public class CreateUserRegisterCommand
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username{ get; set; }
        public string Email{ get; set; }
        public string Password{ get; set; }
    }
}
