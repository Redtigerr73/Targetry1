using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Targetry.Application.Users.Models;

namespace Targetry.Application.Common.Interfaces
{
    public interface IUserRepository
    {
        Task<List<UserDto>> GetAllUsersAsync(CancellationToken cancellationToken);
        Task<UserDto> GetUserById(int id, CancellationToken cancellationToken);
        Task<int> CreateUser(CreateUserDto user, CancellationToken cancellationToken);
        Task<int> UpdateUser(int id, UpdateUserDto user, CancellationToken cancellationToken);
        Task<int> DeleteUser(int id, CancellationToken cancellationToken);
    }
}
