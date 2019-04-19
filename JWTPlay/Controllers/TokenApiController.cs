using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JWTPlay.Controllers
{
    [Route("api/token")]
    public class TokenApiController : Controller
    {
        // GET: api/values
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Silence is golden");
        }

        [Route("decode")]
        [HttpPost]
        public IActionResult Decode([FromBody] string value)
        {
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            JwtSecurityToken jsonToken = handler.ReadJwtToken(value);
            return Ok(jsonToken);
        }
        
    }

}
