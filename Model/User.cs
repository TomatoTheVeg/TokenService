using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Text.Json.Serialization;

namespace TokenManagement.Model
{
    public class User
    {
        [JsonIgnore]
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        [JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty!;
        [Required]  
        [JsonPropertyName("password")]
        public string Password { get; set; } = null!;
        [JsonIgnore]
        public JwtSecurityToken JwtToken { get; set; }

        public User() {}

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
