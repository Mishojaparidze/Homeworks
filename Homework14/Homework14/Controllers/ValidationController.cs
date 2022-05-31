using Microsoft.AspNetCore.Mvc;
using Homework14.Model;

namespace Homework14.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ValidationController : Controller
    {
        [HttpPost("userCheck")]
        public IActionResult Register(user user)
        {
            var validator = new PersonValidator();
            var result = validator.Validate(user);
            if (!result.IsValid)
            {
                return BadRequest(result.Errors[0].ErrorMessage);
            }
            return Ok();

        }
    }
}
