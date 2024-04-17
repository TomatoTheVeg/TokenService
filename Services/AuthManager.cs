using TokenManagement.Model;

namespace TokenManagement.Services
{
    public class AuthManager
    {
        private UserContext _userContext;
        private TokenService _tokenService;
        public AuthManager(UserContext userContext, TokenService tokenService)
        {
            _userContext = userContext;
            _tokenService = tokenService;
        }

        
    }
}
