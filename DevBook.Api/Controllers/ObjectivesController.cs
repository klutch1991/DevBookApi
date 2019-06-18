using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DevBook.Api.Controllers
{
	[ApiController]
	[Route("api/[Controller]")]
	public class ObjectivesController : ControllerBase
	{
		[HttpGet]
		[Produces("application/json")]
		public async Task<IActionResult> GetObjectives()
		{
			await Task.Delay(0);
			return Ok("[ { \"id\" : \"afgr4-wert5-asdf2-asdf3-asdfg\" } ]");
		}
	}
}