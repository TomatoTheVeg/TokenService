using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TokenManagement.Services;

namespace TokenManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private AuthManager _authManager;

        public AuthController(AuthManager authManager)
        {
            _authManager = authManager;
        }

        [HttpPost("register")]
        public string Register()
        {
            return "success";
        }
        [HttpPost("login")]
        public string Login()
        {
            return "success";
        }
    }
}
