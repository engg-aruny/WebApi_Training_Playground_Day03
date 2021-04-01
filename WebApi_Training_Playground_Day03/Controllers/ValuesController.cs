using System.Collections.Generic;
using System.Web.Http;

namespace WebApi_Training_Playground_Day03.Controllers
{
	public class ValuesController : ApiController
	{
		// GET: api/values
		[Route("api/values")]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET: api/values/5
		[Route("api/values/{id}/{name}")]
		public string Get(int id, string name)
		{
			return "value" + name;
		}

		public string Get(int id)
		{
			return "value - Querystring";
		}

		// POST: api/values
		[Route("api/values")]
		public void Post([FromBody] string value)
		{
		}

		// PUT: api/values/5
		[Route("api/values/{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE: api/values/5
		[Route("api/values/{id}")]
		public void Delete(int id)
		{
		}
	}
}