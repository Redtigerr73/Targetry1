using Targetry.UI.Blazor.Data.Dtos;

namespace Targetry.UI.Data.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllUsers();
        Task<UserDto> GetUserById(int id);
        Task<List<UserDto>> GetUsersByRole(string role);
        Task<int> CreateUser(UserDto user);
        Task<int> UpdateUser(UserDto user);
        Task DeleteUser(int id);
    }
}
