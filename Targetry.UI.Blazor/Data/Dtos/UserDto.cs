using Newtonsoft.Json;

namespace Targetry.UI.Blazor.Data.Dtos
{
    public class UserDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("matricule")]
        public string Matricule { get; set; }
		
        [JsonProperty("roleid")]
		public int RoleId { get; set; }
        
    }
}

// 