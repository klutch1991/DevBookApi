using System;
using System.Threading.Tasks;
using DevBook.Data.Abstraction;
using DevBook.Data.Models;
using DevBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevBook.Api.Controllers
{
	[ApiController]
	[Route("api/[Controller]")]
	[Produces("application/json")]
	public class ObjectivesController : ControllerBase
	{
		private readonly IRepository<Objective> _objectives;

		public ObjectivesController(
			IRepository<Objective> objectives) 
				=> _objectives = objectives;

		[HttpGet]
		public async Task<IActionResult> GetObjectives() 
			=> Ok(await _objectives.GetAsync(x => true));

		[HttpGet("{id}", Name = "GetObjective")]
		public async Task<IActionResult> GetObjective(Guid id) 
			=> Ok(await _objectives.GetAsync(id));

		[HttpPost]
		public async Task<IActionResult> CreateObjective([FromBody] ObjectiveToCreate objective)
		{
			var newObjective = new Objective { Description = objective.Description };
			_objectives.Add(newObjective);
			await _objectives.CommitAsync();
			return CreatedAtRoute(
				routeName: "GetObjective", 
				routeValues: new { id = newObjective.Id }, 
				value: newObjective);
		}
	}
}