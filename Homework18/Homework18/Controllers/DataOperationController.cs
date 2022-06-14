using Homework18.Data;
using Homework18.Domain;
using Homework18.Helpers;
using Homework18.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Homework18.Controllers
{
    [Authorize]
    [Route("api/[Controller]")]
    public class DataOperationController : Controller
    {
        private  PersonContext _context;
        public DataOperationController(PersonContext context)
        {
            _context = context;
        }


        private IUserWithRoleServiceWithRole _userService;
        private AppSettings _appSettings;
        public DataOperationController(IUserWithRoleServiceWithRole userService, IOptions<AppSettings> appSettings)
        {
            _userService = userService;
            _appSettings = appSettings.Value;

        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody] UserWithRole user)
        {
            var userLogin = _userService.Login(user);
            if (user==null)
            {
                return BadRequest("Password or Username was Empty");
            }
            var token = GenerateToken(user);
            return Ok(
            new { Token = token  });
        }
        private string GenerateToken(UserWithRole user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                new Claim(ClaimTypes.Name, user.FirstName.ToString()),
                    new Claim(ClaimTypes.Role, user.Username.ToString())

                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            return tokenString;
        }



        [HttpPost("addPerson")]
        public async Task<ActionResult<Person>> AddPerson(Person person)
        {
            _context.Persons.Add(person);
            await _context.SaveChangesAsync();
            return Ok(person.FirstName);
        }
        [HttpGet("getPerson")]
        public async Task<ActionResult<IEnumerable<Person>>> GetPerson()
        {
            await _context.SaveChangesAsync();
            return _context.Persons;
        }

        [HttpGet("get/{id}")]
        public List<Person> GetPersonSecond(int id)
        {
            var x = _context.Persons.Where(x => x.Id == id).ToList();
            return x;
        }

        [HttpGet("get/{querystring}")]
        public IActionResult GetQuery([FromQuery] Person person)
        {
            return Ok(_context.Persons.Where(x => x.Salary > person.Salary && x.WorkExperience > person.WorkExperience));
        }
        [Authorize(Roles=Role.Admin)]
        [HttpDelete("delete/{Person}")]
        public async Task<ActionResult<Person>> DeleteUerById(int Id)
        {
            _context.Persons.Remove(_context.Persons.Find(Id));
            await _context.SaveChangesAsync();
            return Ok();
        }
        [Authorize(Roles = Role.Admin)]
        [HttpPut("PUT/{id}")]
        public async Task<ActionResult<Person>> UpdatePerson(int Id)
        {
            _context.Persons.Update(_context.Persons.Find(Id));
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
