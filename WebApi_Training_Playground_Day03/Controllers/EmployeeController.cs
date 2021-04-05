using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApi_Training_Playground_Day03.Data;
using WebApi_Training_Playground_Day03.Models;
using WebApi_Training_Playground_Day03.Repositories;

namespace WebApi_Training_Playground_Day03.Controllers
{
	public class EmployeeController : ApiController
	{
		private readonly IEmployeeRepository _employeeRepository;

	

		public EmployeeController()
		{
			this._employeeRepository = new EmployeeRepository(new WebApiTrainingDbContext());
		}

		// GET: Employee
		public IHttpActionResult GetEmployees()
		{
			IEnumerable<Employee> employees = null;

			employees = this._employeeRepository.GetEmployees().ToList();

			if (!employees.Any())
			{
				return NotFound();
			}

			return Ok(employees);
		}

		

		// GET: Employee
		public IHttpActionResult GetEmployee(int id)
		{
			Employee employee = null;
			employee = this._employeeRepository.GetEmployee(id);

			if (employee == null)
			{
				return NotFound();
			}

			return Ok(employee);
		}

		public IHttpActionResult PostEmployee([FromBody]Employee employee)
		{
			if (!ModelState.IsValid)
				return BadRequest("Invalid data.");

			employee = this._employeeRepository.AddEmployee(employee);

			return Ok(employee);
		}

		public IHttpActionResult PutEmployee(Employee employee)
		{
			if (!ModelState.IsValid)
				return BadRequest("Invalid data.");

			employee = this._employeeRepository.UpdateEmployee(employee);

			return Ok(employee);
		}

		public IHttpActionResult DeleteEmployee(int id)
		{
			if (id <= 0)
				return BadRequest("Not a valid student id");

			var isDeleted = this._employeeRepository.DeleteEmployee(id);
			if (isDeleted)
			{
				return Ok();
			}
			else
			{
				return BadRequest("Invalid data");
			}
		}
	}
}