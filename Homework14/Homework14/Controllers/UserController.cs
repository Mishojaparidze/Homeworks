using Homework14.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Linq;

namespace Homework14.Controllers
{
    public class UserController : Controller
    {
		private string filepath = @"C:\Users\misho\source\repos\Homeworks\Homework14\Homework14\json.json";
		[HttpPost("add")]
		public IActionResult AddUserById(user user)
		{
			var userrList = new List<user>(){};
			userrList.Add(user);
			if (!System.IO.File.Exists(filepath))
			{
				var myfile = System.IO.File.Create(filepath);
				myfile.Close();
			}
			string jsonString = System.Text.Json.JsonSerializer.Serialize(userrList);
			System.IO.File.AppendAllText(filepath, jsonString + "\n");

			return Ok(userrList);	
		}

		[HttpGet("get")]
		public IActionResult GetUser()
		{
			var y = System.IO.File.ReadAllText(filepath);
			var results = JsonConvert.DeserializeObject<List<user>>(y);
			return Ok(results);
		}

		[HttpGet("get/{id}")]
		public IActionResult GetByID(int param)
		{
			var y = System.IO.File.ReadAllText(filepath);
			var results = JsonConvert.DeserializeObject<List<user>>(y);
			return Ok(results.Where(x=>x.Id>param));
		}

		[HttpGet("get/{querystring}")]
		public IActionResult GetQueryString(int param,string someCity)
		{
			var y = System.IO.File.ReadAllText(filepath);
			var results = JsonConvert.DeserializeObject<List<user>>(y);
			return Ok(results.Where(x => x.Salary > param && x.PersonAddress.City== someCity));
		}


		[HttpPut("get/{querystring}")]
		public IActionResult GetQuery(int Id,user user)
		{
			var y = System.IO.File.ReadAllText(filepath);
			var results = JsonConvert.DeserializeObject<List<user>>(y);
            results[Id].FirstName = user.FirstName;
			results[Id].LastName = user.LastName;
            results[Id].CreateDate = user.CreateDate;
            results[Id].Salary = user.Salary;
			results[Id].WorkExperience = user.WorkExperience;
			results[Id].PersonAddress.Country = user.PersonAddress.Country;
			results[Id].PersonAddress.City = user.PersonAddress.City;
			results[Id].PersonAddress.HomeNumber = user.PersonAddress.HomeNumber;
			return Ok(results);
		}

		[HttpDelete("delete/{User}")]
		public IActionResult DeleteUserById(int Id)
		{
			var y = System.IO.File.ReadAllText(filepath);
			var results = JsonConvert.DeserializeObject<List<user>>(y);
			results.RemoveAt(Id);
			return Ok(results);
		}
	}

}
