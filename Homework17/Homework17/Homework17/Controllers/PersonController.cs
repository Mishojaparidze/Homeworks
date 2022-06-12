using Homework17.Data;
using Homework17_ORM.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework17.Controllers
{
    [Route("api/[Controller]")]
    public class PersonController : Controller
    {
        private readonly PersonContext _context;
        public PersonController(PersonContext context)
        {
            _context = context;
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
        /*
        [HttpGet("get/{querystring}")]
        public async Task<ActionResult<Person>> GetQuery(int param, string someCity)
        {   
           var CityCheck=_context.PersonAddress.Where(x => x.City == someCity).ToList();
            var SalaryCheck = _context.Persons.Where(x => x.Salary > param);
            var findSalary=_context.Persons.Find(_context.Persons.Where(x => x.Salary > param));
            var findCity = _context.PersonAddress.Find(_context.Persons.Where(x => x.Address.City == someCity).ToList());

            return await _context.Persons.Select(x => x.Salary > param && x.Address.City == someCity);
        } */


        [HttpGet("get/{querystring}")]
        public IActionResult GetQuery([FromQuery] Person person)
        {
            return Ok(_context.Persons.Where(x => x.Salary > person.Salary && x.WorkExperience > person.WorkExperience));
        }

        [HttpDelete("delete/{Person}")]
        public async Task<ActionResult<Person>> DeleteUerById(int Id)
        {
            _context.Persons.Remove(_context.Persons.Find(Id));
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("PUT/{id}")]
        public async Task<ActionResult<Person>> UpdatePerson(int Id)
        {
            _context.Persons.Update(_context.Persons.Find(Id));
            await _context.SaveChangesAsync();
            return Ok();
        }







    }

}
