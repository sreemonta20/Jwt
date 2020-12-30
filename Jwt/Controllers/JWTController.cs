using JwtToken.Model;
using JwtToken.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtToken.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class JWTController : ControllerBase
    {
        IUserValidationService _uservalidationService;

        public JWTController(IUserValidationService uservalidationService)
        {
            this._uservalidationService = uservalidationService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]UserEntity userParam)
        {
            var user = this._uservalidationService.IsValidate(userParam.Username, userParam.Password);
            if (user == null)
            {
                return BadRequest(new { message = "UserName or Password is invalid" });
            }
            return Ok(user);
        }
    }
}