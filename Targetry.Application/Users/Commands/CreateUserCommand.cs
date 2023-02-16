using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Targetry.Application.Common.Interfaces;
using Targetry.Application.Users.Models;

namespace Targetry.Application.Users.Commands
{
    public record CreateUserCommand(CreateUserDto UserInput) : IRequest<int>;
    


    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUserRepository _userRepository;

        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            return await _userRepository.CreateUser(request.UserInput, cancellationToken);
        }
    }
}
