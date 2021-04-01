using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi_Training_Playground_Day03.Controllers
{
	[Route("api/testarun")]
    public class TestController : ApiController
    {
	    public string Get(int id)
	    {
		    return "value - Querystring";
	    }


		[HttpPost]
		[Route("api/testarun/AddRecordWithPost")]
		public string AddRecord(int id)
		{
			return "Post - value - Querystring";
		}

		[HttpPost]
		[Route("api/testarun/add")]
		public IHttpActionResult Add(int id)
		{
			return NotFound();
		}

		[HttpPost]
		[Route("api/testarun/addStudent")]
		public Student AddStudent(Student student)
		{
			return student;
		}
	}

    public class Student
    {
	    public int Id { get; set; }

	    public string Name { get; set; }
    }
}
