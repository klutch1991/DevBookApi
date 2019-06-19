using System.Threading.Tasks;
using DevBook.Data;
using DevBook.Data.Models;
using DevBook.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevBook.Api.Controllers
{
	[ApiController]
	[Route("api/[Controller]")]
	[Produces("application/json")]
	public class ObjectivesController : ControllerBase
	{
		private readonly DevBookContext _context;

		public ObjectivesController(
			DevBookContext context) 
				=> _context = context;

		[HttpGet]
		public async Task<IActionResult> GetObjectives()
		{
			var objectives = await _context.Objectives.ToListAsync();
			return Ok(objectives);
		}

		[HttpGet("{id}", Name = "GetObjective")]
		public async Task<IActionResult> GetObjective()
		{
			var objectives = await _context.Objectives.ToListAsync();
			return Ok(objectives);
		}

		[HttpPost]
		public async Task<IActionResult> CreateObjective([FromBody] ObjectiveToCreate objective)
		{
			var newObjective = new Objective { Description = objective.Description };
			_context.Objectives.Add(newObjective);
			await _context.SaveChangesAsync();
			return CreatedAtRoute(
				routeName: "GetObjective", 
				routeValues: new { id = newObjective.Id }, 
				value: newObjective);
		}
	}
}