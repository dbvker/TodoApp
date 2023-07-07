using Microsoft.AspNetCore.Mvc;
using TodoLibrary.Models;

namespace TodoApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TodosController : ControllerBase
{
	[HttpGet]
	public ActionResult<IEnumerable<TodoModel>> Get()
	{
		throw new NotImplementedException();
	}

	[HttpGet("{id}")]
	public ActionResult<TodoModel> Get(int id)
	{
		throw new NotImplementedException();
	}

	[HttpPost]
	public IActionResult Post([FromBody] string value)
	{
		throw new NotImplementedException();
	}

	[HttpPut("{id}")]
	public IActionResult Put(int id, [FromBody] string value)
	{
		throw new NotImplementedException();
	}

	[HttpPut("{id}/Complete")]
	public IActionResult Complete(int id)
	{
		throw new NotImplementedException();
	}

	[HttpDelete("{id}")]
	public IActionResult Delete(int id)
	{
		throw new NotImplementedException();
	}
}
