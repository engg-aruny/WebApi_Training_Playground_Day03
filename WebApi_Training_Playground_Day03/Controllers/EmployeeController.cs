using System.Collections.Generic;
using System.EnterpriseServices;
using System.Web.Http;
using WebApi_Training_Playground_Day02.Models;
using WebApi_Training_Playground_Day02.Repositories;

namespace WebApi_Training_Playground_Day02.Controllers
{
	public class EmployeeController : ApiController
	{
		private readonly IEmployeeRepository _employeeRepository;

		public EmployeeController()
		{
			this._employeeRepository = new EmployeeRepository(new WebApiTrainingDbContext());
		}

		// GET: Employee
		public IEnumerable<Employee> Get()
		{
			return this._employeeRepository.GetEmployees();
		}

		// GET: Employee
		public Employee Get(int id)
		{
			return this._employeeRepository.GetEmployee(id);
		}
	}
}