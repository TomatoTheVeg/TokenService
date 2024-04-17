using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace TokenManagement.Services
{
    public class JwtOptions
    {
        public const string ISSUER = "TokenTester";
        public const string AUDIENCE = "MyCheesecakes";
        const string key = "taa_yoooooooooomaaaayyooooo2323232323!23123123fdfsfsf";
        public static SymmetricSecurityKey GetSymmetricSecurityKey() => new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
    }
}
