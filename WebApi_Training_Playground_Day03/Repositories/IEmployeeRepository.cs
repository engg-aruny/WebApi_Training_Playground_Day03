using System.Collections.Generic;
using WebApi_Training_Playground_Day03.Models;

namespace WebApi_Training_Playground_Day03.Repositories
{
	public interface IEmployeeRepository
	{
		IEnumerable<Employee> GetEmployees();

		Employee GetEmployee(int employeeId);

		Employee AddEmployee(Employee employee);

		Employee UpdateEmployee(Employee employee);

		bool DeleteEmployee(int employeeId);
	}
}
