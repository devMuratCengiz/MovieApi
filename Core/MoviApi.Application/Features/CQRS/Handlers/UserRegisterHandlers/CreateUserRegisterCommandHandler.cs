using Microsoft.AspNetCore.Identity;
using MoviApi.Application.Features.CQRS.Commands.UserRegisterCommands;
using MovieApi.Persistence.Context;
using MovieApi.Persistence.Identity;

namespace MoviApi.Application.Features.CQRS.Handlers.UserRegisterHandlers
{
    public class CreateUserRegisterCommandHandler(MovieContext _context, UserManager<AppUser> _userManager)
    {
        public async Task Handle(CreateUserRegisterCommand command)
        {
            var user = new AppUser()
            {
                Name = command.Name,
                Email = command.Email,
                Surname = command.Surname,
                UserName = command.Username
            };
            await _userManager.CreateAsync(user, command.Password);

        }

    }
}
