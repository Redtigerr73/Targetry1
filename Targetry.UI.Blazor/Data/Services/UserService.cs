using System.Text;
using Newtonsoft.Json;
using Targetry.UI.Blazor.Data.Dtos;
using Targetry.UI.Data.Interfaces;

namespace Targetry.UI.Data.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public UserService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<List<UserDto>> GetAllUsers() //TODO don't forget Cancellation Token
        {
            var httpResponse = await _httpClient.GetAsync("https://localhost:7105/api/v1/Users");
            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot retrieve Users");
            }

            var content = await httpResponse.Content.ReadAsStringAsync();
            var users = string.IsNullOrEmpty(content) ? default : JsonConvert.DeserializeObject<List<UserDto>>(content);
            return users!;
        }

        public async Task<UserDto> GetUserById(int id)
        {
            var httpResponse = await _httpClient.GetAsync($"https://localhost:7105/api/v1/Users/{id}");
            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot retrieve User");
            }

            var content = await httpResponse.Content.ReadAsStringAsync();
            var user = string.IsNullOrEmpty(content) ? default : JsonConvert.DeserializeObject<UserDto>(content);
            return user!;
        }

        public async Task<List<UserDto>> GetUsersByRole(string role)
        {
            var httpResponse = await _httpClient.GetAsync($"https://localhost:7105/api/v1/Users/role/{role}");
            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot retrieve Users");
            }

            var content = await httpResponse.Content.ReadAsStringAsync();
            var users = string.IsNullOrEmpty(content) ? default : JsonConvert.DeserializeObject<List<UserDto>>(content);
            return users!;
        }

        public async Task<int> CreateUser(UserDto user)
        {
            var httpResponse = await _httpClient.PostAsync("https://localhost:7105/api/v1/Users", new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json"));
            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot create User");
            }

            var content = await httpResponse.Content.ReadAsStringAsync();
            var createdUser = string.IsNullOrEmpty(content) ? default : Convert.ToInt32(content);
            return createdUser!;
        }

        public async Task<int> UpdateUser(UserDto user)
        {
            var httpResponse = await _httpClient.PutAsync($"https://localhost:7105/api/v1/Users/{user.Id}", new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json"));
            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot update User");
            }

            var content = await httpResponse.Content.ReadAsStringAsync();
            var updatedUser = string.IsNullOrEmpty(content) ? default : Convert.ToInt32(content);
            return updatedUser!;
        }

        public async Task DeleteUser(int id)
        {
            var httpResponse = await _httpClient.DeleteAsync($"https://localhost:7105/api/v1/Users/{id}");
            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot delete User");
            }
        }



    }
}
