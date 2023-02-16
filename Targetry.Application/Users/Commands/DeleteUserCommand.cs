using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Targetry.Application.Common.Interfaces;

namespace Targetry.Application.Users.Commands
{
    public record DeleteUserCommand(int Id) : IRequest<int>
    {
        public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, int>
        {
            private readonly IUserRepository _userRepository;

            public DeleteUserCommandHandler(IUserRepository userRepository)
            {
                _userRepository = userRepository;
            }

            public async Task<int> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
            {
                return await _userRepository.DeleteUser(request.Id, cancellationToken);
            }
        }
    }
}
