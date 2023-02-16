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
    public record UpdateUserCommand(int Id, UpdateUserDto UpdateUserDto) : IRequest<int>;

    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, int>
    {
        private readonly IUserRepository _userRepository;

        public UpdateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<int> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            return await _userRepository.UpdateUser(request.Id, request.UpdateUserDto, cancellationToken);
        }
    }

}
