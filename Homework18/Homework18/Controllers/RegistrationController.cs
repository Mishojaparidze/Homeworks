using Homework18.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Homework18.Data;

namespace Homework18.Controllers
{

    public class RegistrationController : Controller
    {
        private  PersonContext _userReg;
        public RegistrationController(PersonContext userReg)
        {
            _userReg = userReg;
        }
        

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Create([FromBody] UserReg userReg)
        {
            _userReg.UserRegs.Add(userReg);
            _userReg.SaveChangesAsync();
            ViewBag.message = "The user " + userReg.Username + " is saved successfully";
            return Ok();
        }

    }
    
}
