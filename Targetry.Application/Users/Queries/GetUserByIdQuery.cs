using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Targetry.Application.Common.Interfaces;
using Targetry.Application.Users.Models;

namespace Targetry.Application.Users.Queries
{
    public record GetUserByIdQuery(int id) : IRequest<UserDto>
    {
        
    }

    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserDto>
    {
        private readonly IUserRepository _userRepository;

        public GetUserByIdQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserDto> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            return await _userRepository.GetUserById(request.id, cancellationToken);
        }
    }
}
