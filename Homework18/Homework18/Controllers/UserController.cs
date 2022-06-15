using Microsoft.AspNetCore.Mvc;
using Homework18.Data;
using Homework18.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Homework18.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System;
using Homework18.Helpers;
using Microsoft.Extensions.Options;

namespace Homework18.Controllers
{
    [Authorize]
    [Route("api/[Controller]")]

    public class UserController : Controller
    {
        private IAuthService _userService;
        public UserController(IAuthService userService, IOptions<AppSettings> appSettings)
        {
            _userService = userService;
            _appSettings = appSettings.Value;

        }
        private AppSettings _appSettings;
        private string GenerateToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.UserId.ToString()),
                    new Claim(ClaimTypes.Name, user.Username.ToString())

                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            return tokenString;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody] User user)
        {
            var userLogin = _userService.Login(user);
            if (user==null)
            {
                return BadRequest("Password or Username was Empty");
            }
            var token = GenerateToken(user);
            return Ok(
            new {
                Id = user.UserId,
                Username = user.Username,
                Token = token
            });
        }

    }
}
